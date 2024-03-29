﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public byte[] File { get; set; }
        public string FilePath { get; set; }

        public string UserID { get; set; }
        public string RoleID { get; set; }



        /*
     
         
         The Enrollments property is a navigation property. Navigation properties hold other entities that are related to this entity.
        In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
         
         */
        public ICollection<Attendance> Attendances { get; set; }

        public StudentStatus Status { get; set; }

        public ApplicationUser User { get; set; }

        public ApplicationRole Role { get; set; }

    }
    public enum StudentStatus
    {
        Submitted,
        Approved,
        Rejected
    }

}
