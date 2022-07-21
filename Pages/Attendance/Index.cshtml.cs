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
    public class IndexModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;

        public IndexModel(SerpantWebApp.Data.SerpantWebAppContext context)
        {
            _context = context;
        }

        public IList<Attendances> Attendances { get;set; }

        public async Task OnGetAsync()
        {
            Attendances = await _context.Attendance.ToListAsync();
        }
    }
}
