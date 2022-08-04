using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.SoftwareSecureDeve
{
    public class EditModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;
        private readonly ILogger<IndexModel> logger;

        public EditModel(SerpantWebApp.Data.SerpantWebAppContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            this.logger = logger;
        }

        [BindProperty]
        public Attendance Attendance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendance = await _context.Attendance
                .Include(a => a.Course)
                .Include(a => a.Student)
                .Include(a => a.Teacher).FirstOrDefaultAsync(m => m.LessonSessionID == id);

            if (Attendance == null)
            {
                return NotFound();
            }
           ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID");
           ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FirstName");
           ViewData["TeacherID"] = new SelectList(_context.Teacher, "ID", "FirstName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Attendance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendanceExists(Attendance.LessonSessionID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AttendanceExists(int id)
        {
            return _context.Attendance.Any(e => e.LessonSessionID == id);
        }
    }
}
