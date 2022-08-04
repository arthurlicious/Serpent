using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Models;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Roles
{
    public class EditModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<IndexModel> _logger;

        public EditModel(RoleManager<ApplicationRole> roleManager, ILogger<IndexModel> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }
        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ApplicationRole = await _roleManager.FindByIdAsync(id);
            if (ApplicationRole == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ApplicationRole appRole = await _roleManager.FindByIdAsync(ApplicationRole.Id);
            appRole.Id = ApplicationRole.Id;
            appRole.Name = ApplicationRole.Name;
            appRole.Description = ApplicationRole.Description;

            _logger.LogInformation("Edit page accessed by : " + User.Identity.Name);

            IdentityResult roleRuslt = await _roleManager.UpdateAsync(appRole);
            if (roleRuslt.Succeeded)
            {
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
