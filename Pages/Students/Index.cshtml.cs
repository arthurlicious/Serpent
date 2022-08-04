using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Authorization;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;
        private readonly IAuthorizationService authorizationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<IndexModel> logger;

        public IndexModel(SerpantWebApp.Data.SerpantWebAppContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager, ILogger<IndexModel> logger)
        {
            _context = context;
            this.authorizationService = authorizationService;
            this.userManager = userManager;
            this.logger = logger;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
           /* var student = from co in _context.Student select co;

            var isAuthorized = User.IsInRole(Constants.ContactManagersRole) || User.IsInRole(Constants.ContactAdministratorsRole);

            var currentUserID = userManager.GetUserId(User);

            // Only approved contacts are shown UNLESS you're authorized to see them
            // or you are the owner.
            if (!isAuthorized)
            {
                student = student.Where(co => co.Status == StudentStatus.Approved
                                            || co.UserID == currentUserID);
            }*/

            /*Student = await _context.Student.ToListAsync();*/
            Student = await _context.Student.ToListAsync();
        }
    }
}
