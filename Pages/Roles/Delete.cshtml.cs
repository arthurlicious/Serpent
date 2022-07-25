using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SerpantWebApp.Models;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public DeleteModel(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
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
            ApplicationRole = await _roleManager.FindByIdAsync(id);
            IdentityResult roleResult = await _roleManager.DeleteAsync(ApplicationRole);
            return RedirectToPage("./Index");
        }
    }
}
