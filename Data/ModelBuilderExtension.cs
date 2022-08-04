using SerpantWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.IO;

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

            ApplicationUser studentUser1 = new ApplicationUser()
            {

                Id = "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                UserName = "alexander@gmail.com",
                NormalizedUserName = "alexander@gmail.com",
                Email = "alexander@gmail.com",
                NormalizedEmail = "alexander@gmail.com",
                EmailConfirmed = true

            };

            studentUser1.PasswordHash = passwordHasher.HashPassword(studentUser1, "NgeeAnn@1010");
            modelBuilder.Entity<ApplicationUser>().HasData(studentUser1);


            ApplicationUser studentUser2 = new ApplicationUser()
            {

                Id = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                UserName = "mike@gmail.com",
                NormalizedUserName = "mike@gmail.com",
                Email = "mike@gmail.com",
                NormalizedEmail = "mike@gmail.com",
                EmailConfirmed = true

            };

            studentUser2.PasswordHash = passwordHasher.HashPassword(studentUser2, "NgeeAnn@2010");
            modelBuilder.Entity<ApplicationUser>().HasData(studentUser2);

            ApplicationUser studentUser3 = new ApplicationUser()
            {

                Id = "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                UserName = "bob@gmail.com",
                NormalizedUserName = "bob@gmail.com",
                Email = "bob@gmail.com",
                NormalizedEmail = "bob@gmail.com",
                EmailConfirmed = true

            };

            studentUser3.PasswordHash = passwordHasher.HashPassword(studentUser3, "NgeeAnn@3010");
            modelBuilder.Entity<ApplicationUser>().HasData(studentUser3);



            ApplicationUser studentUser4 = new ApplicationUser()
            {

                Id = "34dfwef33-y525f-h432-r32-evvvreze32433",
                UserName = "hansel@gmail.com",
                NormalizedUserName = "hansel@gmail.com",
                Email = "hansel@gmail.com",
                NormalizedEmail = "hansel@gmail.com",
                EmailConfirmed = true

            };

            studentUser4.PasswordHash = passwordHasher.HashPassword(studentUser4, "NgeeAnn@4010");
            modelBuilder.Entity<ApplicationUser>().HasData(studentUser4);


            ApplicationUser studentUser5 = new ApplicationUser()
            {

                Id = "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                UserName = "grethel@gmail.com",
                NormalizedUserName = "grethel@gmail.com",
                Email = "grethel@gmail.com",
                NormalizedEmail = "grethel@gmail.com",
                EmailConfirmed = true

            };

            studentUser5.PasswordHash = passwordHasher.HashPassword(studentUser5, "NgeeAnn@5010");
            modelBuilder.Entity<ApplicationUser>().HasData(studentUser5);

            ApplicationUser teacherUser1 = new ApplicationUser()
            {

                Id = "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                UserName = "saiful@gmail.com",
                NormalizedUserName = "saiful@gmail.com",
                Email = "saiful@gmail.com",
                NormalizedEmail = "saiful@gmail.com",
                EmailConfirmed = true

            };

            teacherUser1.PasswordHash = passwordHasher.HashPassword(teacherUser1, "Ng&&Ann@1010");
            modelBuilder.Entity<ApplicationUser>().HasData(teacherUser1);

            ApplicationUser teacherUser2 = new ApplicationUser()
            {

                Id = "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                UserName = "charis@gmail.com",
                NormalizedUserName = "charis@gmail.com",
                Email = "charis@gmail.com",
                NormalizedEmail = "charis@gmail.com",
                EmailConfirmed = true

            };

            teacherUser2.PasswordHash = passwordHasher.HashPassword(teacherUser2, "Ng&&Ann@1010");
            modelBuilder.Entity<ApplicationUser>().HasData(teacherUser2);




            // Normal User
            ApplicationUser normalUser1 = new ApplicationUser()
            {

                Id = "vewgj-oytjf-myr34-gre43gh-gw3443",
                UserName = "bruce@gmail.com",
                NormalizedUserName = "bruce@gmail.com",
                Email = "bruce@gmail.com",
                NormalizedEmail = "bruce@gmail.com",
                EmailConfirmed = true

            };

            normalUser1.PasswordHash = passwordHasher.HashPassword(normalUser1, "P@ssword@1010");
            modelBuilder.Entity<ApplicationUser>().HasData(normalUser1);

            ApplicationUser normalUser2 = new ApplicationUser()
            {

                Id = "poh5g-gwgwe43-hjkytg43-few32r-g34b43",
                UserName = "python@gmail.com",
                NormalizedUserName = "python@gmail.com",
                Email = "python@gmail.com",
                NormalizedEmail = "python@gmail.com",
                EmailConfirmed = true

            };

            normalUser2.PasswordHash = passwordHasher.HashPassword(normalUser2, "P@ssword@2010");
            modelBuilder.Entity<ApplicationUser>().HasData(normalUser2);

            ApplicationUser normalUser3 = new ApplicationUser()
            {

                Id = "ueer3-reefwe-idfob3-gre3gr-ptyi32",
                UserName = "will@gmail.com",
                NormalizedUserName = "will@gmail.com",
                Email = "will@gmail.com",
                NormalizedEmail = "will@gmail.com",
                EmailConfirmed = true

            };

            normalUser3.PasswordHash = passwordHasher.HashPassword(normalUser3, "P@ssword@3010");
            modelBuilder.Entity<ApplicationUser>().HasData(normalUser3);





            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new ApplicationRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Teacher", ConcurrencyStamp = "2", NormalizedName = "Teacher" },
                new ApplicationRole() { Id = "rewefac1-c53d-434f-a5gz-pet32gg95711", Name = "Student", ConcurrencyStamp = "3", NormalizedName = "Student" }
                );







            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                // Admin
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "c15eeds50-9053-4323-53de23-dw32435f33" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12884843e5" },
                // Student
                new IdentityUserRole<string>() { RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711", UserId = "rtweetwe1-3gre-yop2-verbm-rwerreww433" },
                new IdentityUserRole<string>() { RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711", UserId = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433" },
                new IdentityUserRole<string>() { RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711", UserId = "effin2343-3fzz-tg3f-2fsa3-eccafwee32433" },
                new IdentityUserRole<string>() { RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711", UserId = "34dfwef33-y525f-h432-r32-evvvreze32433" },
                new IdentityUserRole<string>() { RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711", UserId = "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423" },
                //Teacher
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "vre4yw-h563-g34y45h-fewf32-pqpfowef3" }
            );


            modelBuilder.Entity<Student>().HasData(
                // Add new Student
                new Student
                {
                    ID = 1,
                    LastName = "Alexander",
                    FirstName = "Chong",
                    UserName = "alexander@gmail.com",
                    EnrollmentDate = DateTime.Parse("2021-04-01"),
                    File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                    FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
                    UserID = "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                    RoleID = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                },
                new Student
                {
                    ID = 5,
                    LastName = "Mike",
                    FirstName = "Tyson",
                    UserName = "mike@gmail.com",
                    EnrollmentDate = DateTime.Parse("2021-04-01"),
                    File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                    FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
                    UserID = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                    RoleID = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                }
            );


            modelBuilder.Entity<Teacher>().HasData(
                // Add new Student
                new Teacher
                {
                    ID = 1,
                    LastName = "Saiful",
                    FirstName = "Tan",
                    EnrollmentDate = DateTime.Parse("2016-07-01"),
                    File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                    FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
                    UserID = "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                    RoleID = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                 new Teacher
                 {
                     ID = 2,
                     LastName = "Charis",
                     FirstName = "Chan",
                     EnrollmentDate = DateTime.Parse("2016-07-01"),
                     File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                     FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
                     UserID = "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                     RoleID = "c7b013f0-5201-4317-abd8-c211f91b7330"
                 }
            );


            modelBuilder.Entity<Course>().HasData(
               // Add new Course
               new Course
               {
                   CourseID = 1050,
                   Title = "Fundamental of Programming",
                   Credits = 3,
                   File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                   FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
               },
               new Course
               {
                   CourseID = 2021,
                   Title = "Software Secure Development",
                   Credits = 4,
                   File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                   FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
               },
               new Course
               {
                   CourseID = 3011,
                   Title = "Cryptography",
                   Credits = 5,
                   File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                   FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
               },
                new Course
                {
                    CourseID = 4111,
                    Title = "World Immersion",
                    Credits = 2,
                    File = ReadFileInByte("wwwroot/images/72d3ea47-7628-4ec1-891f-6b9a979f8b3e_Asset 2-8.png"),
                    FilePath = "35f3fef35-3435-3ff33-fe35f-3534f3443534e_Arthur.png",
                }
           );

            modelBuilder.Entity<Attendance>().HasData(
               // Add new Student
               new Attendance
               {
                   LessonSessionID = 1,
                   CourseID = 1050,
                   StudentID = 1,
                   TeacherID = 1,
                   Presence = false
               },
               new Attendance
               {
                   LessonSessionID = 2,
                   CourseID = 2021,
                   StudentID = 5,
                   TeacherID = 1,
                   Presence = false
               }
           );





            /*  modelBuilder.Entity<ApplicationUser>().HasData(
                  new ApplicationUser() { Id = "rtweetwe1-3gre-yop2-verbm-rwerreww433", UserName = "alexander@gmail.com", 
                      NormalizedUserName = "alexander@gmail.com", Email = "alexander@gmail.com", NormalizedEmail = "alexander@gmail.com", 
                      PasswordHash = passwordHasher.HashPassword(adminUser1, "NgeeAnn@1010") },
                  new ApplicationUser() { Id = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433", UserName = "mike@gmail.com", NormalizedUserName = "mike@gmail.com", Email = "mike@gmail.com", NormalizedEmail = "mike@gmail.com" },
                  new ApplicationUser() { Id = "efwefwf443-353d-tg3f-2fsa3-eccafwee32433", UserName = "bob@gmail.com", NormalizedUserName = "bob@gmail.com", Email = "bob@gmail.com", NormalizedEmail = "bob@gmail.com" },
                  new ApplicationUser() { Id = "34dfwef33-y525f-h432-r32-evvvreze32433", UserName = "hansel@gmail.com", NormalizedUserName = "hansel@gmail.com", Email = "hansel@gmail.com", NormalizedEmail = "hansel@gmail.com" },
                  new ApplicationUser() { Id = "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423", UserName = "grethel@gmail.com", NormalizedUserName = "grethel@gmail.com", Email = "grethel@gmail.com", NormalizedEmail = "grethel@gmail.com" }
                  );
  */






            return modelBuilder;
        }

        /*public static string ReadFile(string fileName)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
           
            *//*string fileName = Guid.NewGuid().ToString() + "_" + sPath*//*
            string filePath = Path.Combine(sPath, fileName);

             
            //Open FileStream to read file
            *//*FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);*//*

            //Use BinaryReader to read file stream into byte array.
           // BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
           // data = br.ReadBytes((int)numBytes);

            return filePath;
        }*/

        public static byte[] ReadFileInByte(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
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
