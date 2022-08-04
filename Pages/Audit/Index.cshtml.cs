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
    public class IndexModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public IndexModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        public IList<AuditRecord> AuditRecord { get;set; }

        public async Task OnGetAsync()
        {
            AuditRecord = await _context.AuditRecords.ToListAsync();
        }
    }
}
