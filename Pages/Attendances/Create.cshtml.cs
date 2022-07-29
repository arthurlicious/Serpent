using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Attendances
{
    public class CreateModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public CreateModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID");
        ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Attendance Attendance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attendance.Add(Attendance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
