using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
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
                this.LoginViewModel.RememberMe,
                false);

           /* var claims = new List<Claim>
            {
                new Claim("admin_arthur@gmail.com", LoginViewModel.Email),
                new Claim("P@ssw0rd", LoginViewModel.Password),
                new Claim(ClaimTypes.Role, "Administrator"),
            };
            var identity = new ClaimsIdentity(claims, "CookieForAdmin");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

        */


            if (result.Succeeded)
            {
                return RedirectToPage("/Index");
            }
            else
            {
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
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me!")]
        public bool RememberMe { get; set; }
    }
}
