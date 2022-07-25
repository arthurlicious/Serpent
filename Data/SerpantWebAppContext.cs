using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Models;

namespace SerpantWebApp.Data
{
    public class SerpantWebAppContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public SerpantWebAppContext (DbContextOptions<SerpantWebAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }


        public DbSet<SerpantWebApp.Models.Classrooms> Classroom { get; set; }

        public DbSet<SerpantWebApp.Models.Attendances> Attendance { get; set; }
    }
}
