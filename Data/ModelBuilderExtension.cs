using SerpantWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace SerpantWebApp.Data
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<ApplicationUser>().HasData(

                CreateAdmin("5", true, "arthurchongs@gmail.com", "arthurchongs@gmail.com".ToUpper(), "arthurchongs@gmail.com", "arthurchongs@gmail.com".ToUpper(), "P@ssw0rd1", true, Guid.NewGuid().ToString()),
                CreateAdmin("6", true, "jameschua@gmail.com", "jameschua@gmail.com".ToUpper(), "jameschua@gmail.com", "jameschua@gmail.com".ToUpper(), "P@ssw0rd2", true, Guid.NewGuid().ToString()),
                CreateAdmin("7", true, "peterparker@gmail.com", "peterparker@gmail.com".ToUpper(), "peterparker@gmail.com", "peterparker@gmail.com".ToUpper(), "P@ssw0rd3", true, Guid.NewGuid().ToString())
                );*/

           /* context.Database.EnsureCreated();

            // Look for any students.
            if (context.ApplicationUser.Any())
            {
                return;   // DB has been seeded
            }*/

            ApplicationUser adminUser1 = new ApplicationUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12884843e5",
                UserName = "petertestacct3010@gmail.com",
                NormalizedUserName = "petertestacct3010@gmail.com",
                Email = "petertestacct3010@gmail.com",
                NormalizedEmail = "petertestacct3010@gmail.com",
                EmailConfirmed = true
                
            };

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser1.PasswordHash = passwordHasher.HashPassword(adminUser1, "P@ssw0rd1010");
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser1);

            ApplicationUser adminUser2 = new ApplicationUser()
            {

                Id = "c15eeds50-9053-4323-53de23-dw32435f33",
                UserName = "jamesTestAcct3010@gmail.com",
                NormalizedUserName = "jamesTestAcct3010@gmail.com",
                Email = "jamesTestAcct3010@gmail.com",
                NormalizedEmail = "jamesTestAcct3010@gmail.com",
                EmailConfirmed = true

            };

            adminUser2.PasswordHash = passwordHasher.HashPassword(adminUser2, "P@ssw0rd3010");
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser2);


            /*
                        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                            new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
                            );
            */


            return modelBuilder;
        }

      /*  public static ApplicationUser CreateAdmin(string id, bool emailConfirmed, string email, string normalizedEmail, string name, string normalizedUsername, string password, bool lockout, string securityStamp)
        {
            var admin = new ApplicationUser();



            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");





            *//*          admin.PasswordHash = salt.ToString();*//*
            //Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

        
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));





            admin.Id = id;
            admin.EmailConfirmed = emailConfirmed;
            admin.PasswordHash = "mgH2geR/CHabd0CzvA5pwhp/fFr5QpmNmFDUc1/Jl2k=";
            admin.UserName = name;
            admin.Email = email;
            admin.LockoutEnabled = lockout;
            admin.NormalizedEmail = normalizedEmail;
            admin.NormalizedUserName = normalizedUsername;
            admin.SecurityStamp = securityStamp;
            return admin;
        }*/
    }
}
