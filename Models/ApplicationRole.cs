﻿using Microsoft.AspNetCore.Identity;
using System;

namespace SerpantWebApp.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }
    }
}
