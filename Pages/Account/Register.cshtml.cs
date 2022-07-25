using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SerpantWebApp.Models;
using SerpantWebApp.Services;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService emailService;

        // going to the dependency injection to inject the IEmailService
        public RegisterModel(UserManager<ApplicationUser> userManager, IEmailService emailService)
        {

            _userManager = userManager;
            this.emailService = emailService;
        }
        [BindProperty]
        // property here for data binding
        public RegisterViewModel RegisterViewModel { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            // Validating email address

            // Create the user
            var user = new ApplicationUser
            {
                Email = RegisterViewModel.Email,
                UserName = RegisterViewModel.Email
            };

            var result = await _userManager.CreateAsync(user, RegisterViewModel.Password);
            if (result.Succeeded)
            {
                var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.PageLink(pageName: "/Account/ConfirmEmail", values: new { userId = user.Id, token = confirmationToken });
                /*var message = new MailMessage(
                    "arthurchongs@gmail.com",
                    user.Email,
                    "Please Confirm your Email",
                    $"Please Click on this Link to Confirm your Email Address : {confirmationLink}"
                    );*/
                /*using (var emailClient = new SmtpClient())
                {
                    emailClient.Port = 587;
                    emailClient.Host = "smtp-relay.sendinblue.com";
                    emailClient.EnableSsl = true;
                    emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    emailClient.Credentials = new NetworkCredential("arthurchongs@gmail.com", "Uw6b3p0WDYS1yx47");

                    await emailClient.SendMailAsync(message);
                }*/
                await emailService.SendAsync("arthurchongs@gmail.com",
                    user.Email,
                    "Please Confirm your Email",
                    $"Please Click on this Link to Confirm your Email Address : {confirmationLink}");

                return RedirectToPage("/Account/Login");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("Register", error.Description);
                }
                return Page();
            }
        }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
