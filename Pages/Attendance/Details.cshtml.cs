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
    public class DetailsModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DetailsModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

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
    }
}
