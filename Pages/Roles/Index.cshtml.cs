using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IAuthorizationService authorizationService;

        public IndexModel(RoleManager<ApplicationRole> roleManager, IAuthorizationService authorizationService)
        {
            _roleManager = roleManager;
            this.authorizationService = authorizationService;
        }
        public List<ApplicationRole> ApplicationRole { get; set; }
        public async Task OnGetAsync()
        {
            // requires using ContactManager.Authorization;
            /*var isAuthorized = await authorizationService.AuthorizeAsync(
                                                        User, ,
                                                        ContactOperations.Create);*/


            // Get a list of roles
            ApplicationRole = await _roleManager.Roles.ToListAsync();
        }
    }
}
