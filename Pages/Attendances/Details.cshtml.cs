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
    public class DetailsModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DetailsModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

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
    }
}
