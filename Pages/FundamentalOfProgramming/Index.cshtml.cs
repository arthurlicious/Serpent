using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Data;
using SerpantWebApp.Models;

namespace SerpantWebApp.Pages.Attendances
{
    public class IndexModel : PageModel
    {
        private readonly SerpantWebApp.Data.SerpantWebAppContext _context;
        private readonly ILogger<IndexModel> logger;

        public IndexModel(SerpantWebApp.Data.SerpantWebAppContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            this.logger = logger;
        }



        public IList<Attendance> Attendance { get;set; }

        public async Task OnGetAsync()
        {
            Attendance = await _context.Attendance
                .Include(a => a.Teacher)
                .Include(a => a.Course)
                .Include(a => a.Student).ToListAsync();
        }


    }
}

