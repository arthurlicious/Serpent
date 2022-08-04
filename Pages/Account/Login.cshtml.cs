using AspNetCore.ReCaptcha;
using CryptoHelper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Data;
using SerpantWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Account
{
    [ValidateReCaptcha]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly SerpantWebAppContext _context;
        private readonly ILogger<IndexModel> logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager, SerpantWebAppContext context, ILogger<IndexModel> logger)
        {
            _signInManager = signInManager;
            _context = context;
            this.logger = logger;
        }
        [BindProperty]
        public LoginViewModel LoginViewModel { get; set; }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();


            var result = await _signInManager.PasswordSignInAsync(
                this.LoginViewModel.Email,
                this.LoginViewModel.Password,
                false,
                true);




            if (result.Succeeded)
            {

                return LocalRedirect("/Index");
            }
            else
            {
                this.logger.LogInformation("User failed to Login : " + this.LoginViewModel.Email);

                // Login failed attempt - create an audit record
                var auditrecord = new AuditRecord();
                auditrecord.AuditActionType = "Failed Login";
                auditrecord.DateTimeStamp = DateTime.Now;
                auditrecord.KeyProductFieldID = 0;
                // 999 – dummy record
                auditrecord.Username = this.LoginViewModel.Email;
                // save the email used for the failed login
                _context.AuditRecords.Add(auditrecord);
                await _context.SaveChangesAsync();
            }


            if (result.RequiresTwoFactor)
            {
                return RedirectToPage("/Account/LoginTwoFactorWithAuthenticator", new
                {
                    /*RememberMe  = this.LoginViewModel.RememberMe,*/
                    id = this.LoginViewModel.Email
                });
            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("Login", "You are locked out.");
            }
            else
            {
                ModelState.AddModelError("Login", "Failed to login.");
            }



            return Page();
        }

    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }


}
