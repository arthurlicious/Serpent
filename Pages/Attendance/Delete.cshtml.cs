using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Attendance
{
    public class DeleteModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DeleteModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Attendances Attendances { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendances = await _context.Attendance.FirstOrDefaultAsync(m => m.SID == id);

            if (Attendances == null)
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

            Attendances = await _context.Attendance.FindAsync(id);

            if (Attendances != null)
            {
                _context.Attendance.Remove(Attendances);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
