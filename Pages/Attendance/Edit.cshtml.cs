using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Attendance
{
    public class EditModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public EditModel(SerpantWebApp.Data.SerpantWebAppContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Attendances).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendancesExists(Attendances.SID))
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

        private bool AttendancesExists(int id)
        {
            return _context.Attendance.Any(e => e.SID == id);
        }
    }
}
