using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Models;

namespace SerpantWebApp.Data
{
    public class SerpantWebAppContext : IdentityDbContext
    {
        public SerpantWebAppContext (DbContextOptions<SerpantWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<SerpantWebApp.Models.Classrooms> Classroom { get; set; }
    }
}
