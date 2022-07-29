using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SerpantWebApp.Models;
using SerpantWebApp.Services;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Account
{
    public class LoginTwoFactorWithAuthenticatorModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailService emailService;

        [BindProperty]
        public AuthenticatorMFA AuthenticatorMFA { get; set; }
        public LoginTwoFactorWithAuthenticatorModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IEmailService emailService)
        {

            this.userManager = userManager;
            this.AuthenticatorMFA = new AuthenticatorMFA();
            this.signInManager = signInManager;
            this.emailService = emailService;
        }
        /*public void OnGet(bool rememberMe)
        {
            this.AuthenticatorMFA.SecurityCode = string.Empty;
            // when the btn is click and the form is posted back we need to create a post handler
            this.AuthenticatorMFA.RememberMe = rememberMe;
        }*/

        public async Task OnGetAsync(string id)
        {
            this.AuthenticatorMFA.SecurityCode = string.Empty;
            /*this.AuthenticatorMFA.RememberMe = rememberMe;*/
            this.AuthenticatorMFA.UserID = id;
            /*var user = await userManager.GetUserAsync(base.User);
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
                this.AuthenticatorMFA.Key = key;
            }*/
            /* var user = await userManager.GetUserAsync(base.User);*/
            /*     var user = await userManager.FindByNameAsync(User);*/
           /* var user = await userManager.GetUserAsync(AuthenticatorMFA.UserID.ToString);*/

            var target = await userManager.FindByEmailAsync(id);

            var securityCode = await userManager.GenerateTwoFactorTokenAsync(target, this.userManager.Options.Tokens.EmailConfirmationTokenProvider);

            await emailService.SendAsync("arthurchongs@gmail.com", target.Email, "My", $"Authentication here : {securityCode}");
            /*var result = await emailService.SendAsync(
             "arthurchongs@gmail.com",
             email,
             "My Web App's OTP", $"Please use this code as OTP {ViewModel.SecurityCode}"));*/

            /*this.AuthenticatorMFA.Key = key;*/
           
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            /*var result = await signInManager.TwoFactorAuthenticatorSignInAsync(this.AuthenticatorMFA.SecurityCode, this.AuthenticatorMFA.RememberMe, false);
*/
            var result = await signInManager.TwoFactorSignInAsync(this.userManager.Options.Tokens.EmailConfirmationTokenProvider, this.AuthenticatorMFA.SecurityCode, false, false);

             /* await signInManager.TwoFactorAuthenticatorSignInAsync()*/
            if (result.Succeeded)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("Authenticator2FA", "You are locked out.");
                }
                else
                {
                    ModelState.AddModelError("Authenticator2FA", "Failed to login.");
                }
                return Page();
            }
        }
    }

    public class AuthenticatorMFA
    {
        [Required]
        [Display(Name = "Code")]
        public string SecurityCode { get; set; }
        public bool RememberMe { get; set; }
        public string Key { get; set; }
        public string UserID { get; set; }
    }
}
