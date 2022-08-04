using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Models;
using System;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Roles
{
    public class CreateModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<IndexModel> logger;

        public CreateModel(RoleManager<ApplicationRole> roleManager, ILogger<IndexModel> logger)
        {
            _roleManager = roleManager;
            this.logger = logger;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ApplicationRole.CreatedDate = DateTime.UtcNow;
            ApplicationRole.IPAddress =
            Request.HttpContext.Connection.RemoteIpAddress.ToString();

            this.logger.LogInformation("Role created accessed by : " + User.Identity.Name);

            IdentityResult roleRuslt = await _roleManager.CreateAsync(ApplicationRole);


            return RedirectToPage("Index");
        }
    }
}
