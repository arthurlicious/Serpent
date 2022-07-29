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
using SerpantWebApp.Authorization;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        private readonly IAuthorizationService authorizationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(SerpantWebApp.Data.SerpantWebAppContext context, IWebHostEnvironment environment, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _environment = environment;
            this.authorizationService = authorizationService;
            this.userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(Student student)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           /* Student.UserID = student.UserID;

            // requires using StudentManager.Authorization
            var isAuthorized = await authorizationService.AuthorizeAsync(User, Student, StudentOperations.Create);

            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }*/

            
            if (FormFile != null)
            {
                if (student.File != null)
                {
                    string filePath = Path.Combine(_environment.WebRootPath, "images", student.FilePath);
                    System.IO.File.Delete(filePath);
                }
                Student.FilePath = ProcessUploadedFile();
            }
           
            


            using (var memoryStream = new MemoryStream())
            {
                await FormFile.CopyToAsync(memoryStream);

                // Upload the file if less than 2 MB
                if (memoryStream.Length < 2097152)
                {
                    

                    Student.File = memoryStream.ToArray();
                }
                else
                {
                    ModelState.AddModelError("File", "The file is too large.");
                }
            }




            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

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

    }


}


