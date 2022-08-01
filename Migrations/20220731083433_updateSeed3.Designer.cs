﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SerpantWebApp.Data;

namespace SerpantWebApp.Migrations
{
    [DbContext(typeof(SerpantWebAppContext))]
    [Migration("20220731083433_updateSeed3")]
    partial class updateSeed3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "c15eeds50-9053-4323-53de23-dw32435f33",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12884843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                            RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                        },
                        new
                        {
                            UserId = "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                            RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                        },
                        new
                        {
                            UserId = "34dfwef33-y525f-h432-r32-evvvreze32433",
                            RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                        },
                        new
                        {
                            UserId = "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                            RoleId = "rewefac1-c53d-434f-a5gz-pet32gg95711"
                        },
                        new
                        {
                            UserId = "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SerpantWebApp.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "1",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            ConcurrencyStamp = "2",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Teacher",
                            NormalizedName = "Teacher"
                        },
                        new
                        {
                            Id = "rewefac1-c53d-434f-a5gz-pet32gg95711",
                            ConcurrencyStamp = "3",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Student",
                            NormalizedName = "Student"
                        });
                });

            modelBuilder.Entity("SerpantWebApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12884843e5",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "d9472c12-514d-417e-8d45-170485e37e6c",
                            Email = "petertestacct3010@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "petertestacct3010@gmail.com",
                            NormalizedUserName = "petertestacct3010@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEMZqIj9iWQannfU2kj/eZiTxUexf8Uj1A6MdJILZ9sPdAHae10keWRGMW2HOKw0HDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aaab0f59-7d7c-47c7-bdc6-99d7a3feabc4",
                            TwoFactorEnabled = false,
                            UserName = "petertestacct3010@gmail.com"
                        },
                        new
                        {
                            Id = "c15eeds50-9053-4323-53de23-dw32435f33",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "50bf100b-cdca-4b5c-9d4f-aeb77d8f6024",
                            Email = "jamesTestAcct3010@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "jamesTestAcct3010@gmail.com",
                            NormalizedUserName = "jamesTestAcct3010@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEvXBmxMjyRDU6+32kXsR16cgzOJWgghkblgQ2gou/7Na/Tu96eCaHw0h4WhigSNww==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d895806-d67a-4e39-a3c5-1a5772834393",
                            TwoFactorEnabled = false,
                            UserName = "jamesTestAcct3010@gmail.com"
                        },
                        new
                        {
                            Id = "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "1e0e98c6-b47e-437c-895e-53ec549dd6d6",
                            Email = "alexander@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "alexander@gmail.com",
                            NormalizedUserName = "alexander@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEA3RVynSbyxhv5dF+F2qxogIY27SOlJTRMT/3jHrMmYDy1P7O9DAx9nKJniPYu4vZg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "302fc2f3-7979-416d-9d26-44cd7ea47158",
                            TwoFactorEnabled = false,
                            UserName = "alexander@gmail.com"
                        },
                        new
                        {
                            Id = "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "ebb34ced-2957-4769-ae0a-4cef5ead5ffa",
                            Email = "mike@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "mike@gmail.com",
                            NormalizedUserName = "mike@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEOviw2j8kIDL4/2wS33WWHMQeaL0/iV5Y9SD4dpdE+ymcgn+n0OTbdbA7PMbIzG6nQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "48ebdb15-aa11-4546-ba3f-cbc2003d72e2",
                            TwoFactorEnabled = false,
                            UserName = "mike@gmail.com"
                        },
                        new
                        {
                            Id = "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "63b43bcf-bbcd-47e5-ae67-8c1613083046",
                            Email = "bob@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "bob@gmail.com",
                            NormalizedUserName = "bob@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEP10ZkuF7v8f43T5rJYUdNhFxqZFp8HLwE7aO1o6rQ7MstQlPgDomGeb+rckNhukHw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4752c4b4-530f-4002-9ef4-042a2913f3df",
                            TwoFactorEnabled = false,
                            UserName = "bob@gmail.com"
                        },
                        new
                        {
                            Id = "34dfwef33-y525f-h432-r32-evvvreze32433",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "33051d10-52aa-495f-a80b-19b868ffc854",
                            Email = "hansel@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "hansel@gmail.com",
                            NormalizedUserName = "hansel@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAECqpdNkPVIBKauqjMTBzwvHlssTOmzcXJLTGo/pnFosXbyNVlF0VBb8YuZnRhZ0WVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9264e859-93a9-422b-b5ae-f6f770c9dc3b",
                            TwoFactorEnabled = false,
                            UserName = "hansel@gmail.com"
                        },
                        new
                        {
                            Id = "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "a9c615d6-35c9-4295-bbc6-ef6a9bae8b19",
                            Email = "grethel@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "grethel@gmail.com",
                            NormalizedUserName = "grethel@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGz0UJKZqCkPTovOZUB4xz+KptdPptr951OUib8PFF7WIhEmLAgHsrvsX0RkpG2+tg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "848f51f6-e296-4459-80f1-164481b27838",
                            TwoFactorEnabled = false,
                            UserName = "grethel@gmail.com"
                        },
                        new
                        {
                            Id = "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "47938270-090a-415d-be51-a86ccd70870a",
                            Email = "saiful@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "saiful@gmail.com",
                            NormalizedUserName = "saiful@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHZpeYuM0gGIzDn81OK1i29bh8ObHESI7khisiCo34Oj73lwTwTrFDxlXRv7bbhb9A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00fb5ed7-9b7e-4ef8-a45b-cd0694feed90",
                            TwoFactorEnabled = false,
                            UserName = "saiful@gmail.com"
                        },
                        new
                        {
                            Id = "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                            AccessFailedCount = 0,
                            Age = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "f4e3d985-fa87-4afa-b012-67560b4334d4",
                            Email = "charis@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "charis@gmail.com",
                            NormalizedUserName = "charis@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEPrjl+1IcAU5tDLaJyw/GF630HOeGjWlkosFcXyKBDmELuwVXQM1TIynoZy2wYR86A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f0684d9-7c79-40f2-96c4-dd3ef3c36bde",
                            TwoFactorEnabled = false,
                            UserName = "charis@gmail.com"
                        });
                });

            modelBuilder.Entity("SerpantWebApp.Models.Attendance", b =>
                {
                    b.Property<int>("LessonSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("LessonSessionID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("SerpantWebApp.Models.AttendanceSheetForMath", b =>
                {
                    b.Property<int>("LessonSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonSessionID");

                    b.ToTable("AttendanceSheetForMath");
                });

            modelBuilder.Entity("SerpantWebApp.Models.AttendanceSheetForProgramming", b =>
                {
                    b.Property<int>("LessonSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Presence")
                        .HasColumnType("bit");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonSessionID");

                    b.ToTable("AttendanceSheetForProgramming");
                });

            modelBuilder.Entity("SerpantWebApp.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherStaffID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("TeacherStaffID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SerpantWebApp.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SerpantWebApp.Models.Teacher", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StaffID");

                    b.HasIndex("UserID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SerpantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SerpantWebApp.Models.Attendance", b =>
                {
                    b.HasOne("SerpantWebApp.Models.Course", "Course")
                        .WithMany("Attendances")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SerpantWebApp.Models.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SerpantWebApp.Models.Course", b =>
                {
                    b.HasOne("SerpantWebApp.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherStaffID");
                });

            modelBuilder.Entity("SerpantWebApp.Models.Student", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.HasOne("SerpantWebApp.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("SerpantWebApp.Models.Teacher", b =>
                {
                    b.HasOne("SerpantWebApp.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}