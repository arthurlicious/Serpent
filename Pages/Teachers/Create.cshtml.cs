using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Teachers
{
    public class CreateModel : PageModel
    {

        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;
        private readonly IAuthorizationService authorizationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(SerpantWebApp.Data.SerpantWebAppContext context, IWebHostEnvironment environment,
            IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _environment = environment;
            this.authorizationService = authorizationService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }



        public string selectedusername { set; get; }
        public SelectList UsersSelectList;
        // contain a list of Users to populate select box

        [BindProperty]
        public Teacher Teacher { get; set; }
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }

        public async Task OnGetAsync()
        { //HTTPGet - when form is being loaded
          //get list of roles and users

            IQueryable<string> UsersQuery = from u in _context.Users orderby u.UserName select u.UserName;
            UsersSelectList = new SelectList(await UsersQuery.Distinct().ToListAsync());
            // Get all the roles

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(Teacher teacher, string selectedusername)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            //When the Assign button is pressed
            if ((selectedusername == null))
            {
                return Page();
            }
            ApplicationUser AppUser = _context.Users.SingleOrDefault(u => u.UserName ==
           selectedusername);

         
            /*IdentityResult roleResult = await userManager.AddToRoleAsync(AppUser, AppRole.Name);
            if (roleResult.Succeeded)
            {
                TempData["message"] = "Role added to this user successfully";
                return RedirectToPage("Manage");
            }
    */
            /* Student.UserID = student.UserID;

             // requires using StudentManager.Authorization
             var isAuthorized = await authorizationService.AuthorizeAsync(User, Student, StudentOperations.Create);

             if (!isAuthorized.Succeeded)
             {
                 return Forbid();
             }*/


            if (FormFile != null)
            {
                if (teacher.FilePath != null)
                {
                    string filePath = Path.Combine(_environment.WebRootPath, "images", teacher.FilePath);
                    System.IO.File.Delete(filePath);
                }
                Teacher.FilePath = ProcessUploadedFile();
            }




            using (var memoryStream = new MemoryStream())
            {
                await FormFile.CopyToAsync(memoryStream);

                // Upload the file if less than 2 MB
                if (memoryStream.Length < 2097152)
                {


                    Teacher.File = memoryStream.ToArray();
                }
                else
                {
                    ModelState.AddModelError("File", "The file is too large.");
                }
            }




            _context.Teacher.Add(Teacher);


            // Once a record is added, create an audit record
            if (await _context.SaveChangesAsync() > 0)
            {
                // Create an auditrecord object
                var auditrecord = new AuditRecord();
                auditrecord.AuditActionType = "Add Teacher Record";
                auditrecord.DateTimeStamp = DateTime.Now;
                auditrecord.KeyProductFieldID = Teacher.ID;
                // Get current logged-in user
                var userID = User.Identity.Name.ToString();
                auditrecord.Username = userID;
                _context.AuditRecords.Add(auditrecord);
                await _context.SaveChangesAsync();
            }
            /*
                        await _context.SaveChangesAsync();*/

            return RedirectToPage("./Index");
        }

        private string ProcessUploadedFile()
        {
            string fileName = null;
            if (FormFile != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                fileName = Guid.NewGuid().ToString() + "_" + FormFile.FileName;
                string filePath = Path.Combine(uploadsFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    FormFile.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        /// <summary>
        /// 
        /// </summary>

     
    }
}
