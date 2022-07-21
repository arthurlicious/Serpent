using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Classroom
{
    public class DetailsModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DetailsModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        public Classrooms Classrooms { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Classrooms = await _context.Classroom.FirstOrDefaultAsync(m => m.ID == id);

            if (Classrooms == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
