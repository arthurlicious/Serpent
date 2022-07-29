using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SerpantWebApp.Models
{
    public class Teacher
    {
        [Key]
        public int StaffID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }


        public byte[] File { get; set; }
        public string FilePath { get; set; }

        public int CourseID { get; set; }


        public string UserID { get; set; }

        public ApplicationUser User { get; set; }
        /*
     
         
         The Courses property is a navigation property. Navigation properties hold other entities that are related to this entity.
        In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
         
         */
        public ICollection<Course> Courses { get; set; }
    }
}
