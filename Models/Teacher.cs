using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime? EnrollmentDate { get; set; }


        public byte[] File { get; set; }
        public string FilePath { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }


        public string UserID { get; set; }
        public string RoleID { get; set; }


        public ICollection<Attendance> Attendances { get; set; }
        public ApplicationUser User { get; set; }

        public ApplicationRole Role { get; set; }

        /*
     
         
         The Courses property is a navigation property. Navigation properties hold other entities that are related to this entity.
        In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
         
         */
       /* public ICollection<Course> Courses { get; set; }*/
    }
}
