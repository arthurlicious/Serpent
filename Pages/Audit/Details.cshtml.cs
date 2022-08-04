using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Audit
{
    public class DetailsModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public DetailsModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        public AuditRecord AuditRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuditRecord = await _context.AuditRecords.FirstOrDefaultAsync(m => m.AuditID == id);

            if (AuditRecord == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
