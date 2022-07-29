using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SerpantWebApp.Models;
using SerpantWebApp.Services;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Account
{
    [Authorize]
    public class AuthenticatorWithMFASetupModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailService emailService;

        [BindProperty]
        public SetupMFAViewModel ViewModel { get; set; }

        [BindProperty]
        public bool Succeeded { get; set; }

        public AuthenticatorWithMFASetupModel(UserManager<ApplicationUser> userManager, IEmailService emailService)
        {
            this.userManager = userManager;
            this.emailService = emailService;
            this.ViewModel = new SetupMFAViewModel();
            this.Succeeded = false; 
        }
        public async Task OnGetAsync(string email)
        {
            var user = await userManager.GetUserAsync(base.User);
            var key = await userManager.GetAuthenticatorKeyAsync(user);

            // delete the key from the table and generate a new one.
            await userManager.ResetAuthenticatorKeyAsync(user);

            if (string.IsNullOrEmpty(key))
            {
                // if no key exists, generate one and persist it
                await userManager.ResetAuthenticatorKeyAsync(user);
                // get the key we just created
                key = await userManager.GetAuthenticatorKeyAsync(user);

                // the key we want it to be post back and forth, right in case the user entered the wrong code accidentally
                this.ViewModel.Key = key;
            }

            var target = await userManager.FindByEmailAsync(user.UserName);

            var securityCode = await userManager.GenerateTwoFactorTokenAsync(target, this.userManager.Options.Tokens.EmailConfirmationTokenProvider);

            await emailService.SendAsync("arthurchongs@gmail.com", target.Email, "My", $"Authentication here : {securityCode}");
            /*var result = await emailService.SendAsync(
             "arthurchongs@gmail.com",
             email,
             "My Web App's OTP", $"Please use this code as OTP {ViewModel.SecurityCode}"));*/

            this.ViewModel.Key = key;
        }

        public async Task<IActionResult> OnPostAsync(string email)
        {
            if (!ModelState.IsValid) return Page();

            var user = await this.userManager.GetUserAsync(base.User);
            /*     var user = await userManager.FindByEmailAsync(email);*/

            if (await userManager.VerifyTwoFactorTokenAsync(user, this.userManager.Options.Tokens.EmailConfirmationTokenProvider, this.ViewModel.SecurityCode))
            {
                await userManager.SetTwoFactorEnabledAsync(user, true);
                this.Succeeded = true;
            }
            else
            {
                ModelState.AddModelError("AuthenticatorSetup",
                                         "Something went wrong with authenticator setup.");
            }
            return Page();
        }

    }

    public class SetupMFAViewModel 
    {
        public string Key { get; set; }

        [Required]
        [Display (Name = "Code")]
        public string SecurityCode { get; set; }
    }

}
