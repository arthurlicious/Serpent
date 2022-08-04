using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
            builder.Seed();

            /*builder.Entity<Course>().ToTable("Course");
            builder.Entity<Attendance>().ToTable("Attendance");
            builder.Entity<Student>().ToTable("Student");*/
           

          

        }

        public DbSet<SerpantWebApp.Models.Student> Student { get; set; }
        public DbSet<SerpantWebApp.Models.Attendance> Attendance { get; set; }
        public DbSet<SerpantWebApp.Models.Course> Course { get; set; }
   
        public DbSet<SerpantWebApp.Models.Teacher> Teacher { get; set; }

        public DbSet<SerpantWebApp.Models.AuditRecord> AuditRecords { get; set; }




        /*public DbSet<SerpantWebApp.Models.Attendances> Attendance { get; set; }*/

        /*      private void SeedRoles(ModelBuilder modelBuilder)
              {
                  modelBuilder.Entity<IdentityRole>().HasData(
                   new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                   new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Teacher", ConcurrencyStamp = "2", NormalizedName = "Human Resource" }
                   );

              }*/

    }
}
