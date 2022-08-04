using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SerpantWebApp.Data;
using SerpantWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerpantWebApp.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SerpantWebAppContext context;

        public IEnumerable<Course> Courses { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, SerpantWebAppContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public void OnGet()
        {
            Courses = this.context.Course.ToList();
        }
    }
}
