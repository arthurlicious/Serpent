using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Models;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<IndexModel> logger;

        public DeleteModel(RoleManager<ApplicationRole> roleManager, ILogger<IndexModel> logger)
        {
            _roleManager = roleManager;
            this.logger = logger;
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
        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            this.logger.LogInformation("Delete ROLE accessed by : " + User.Identity.Name);
            ApplicationRole = await _roleManager.FindByIdAsync(id);
            IdentityResult roleResult = await _roleManager.DeleteAsync(ApplicationRole);
            return RedirectToPage("./Index");
        }
    }
}
