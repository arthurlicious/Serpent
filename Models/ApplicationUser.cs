﻿using Microsoft.AspNetCore.Identity;
using System;

namespace SerpantWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

    }
}
