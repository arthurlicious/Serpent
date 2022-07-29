using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Attendances
{
    public class DeleteModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DeleteModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
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
                .Include(a => a.Student).FirstOrDefaultAsync(m => m.LessonSessionID == id);

            if (Attendance == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendance = await _context.Attendance.FindAsync(id);

            if (Attendance != null)
            {
                _context.Attendance.Remove(Attendance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
