using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

  
        public byte[] File { get; set; }
        public string FilePath { get; set; }

        public string UserID { get; set; }



        /*
     
         
         The Enrollments property is a navigation property. Navigation properties hold other entities that are related to this entity.
        In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
         
         */
        public ICollection<Attendance> Attendances { get; set; }

        public StudentStatus Status { get; set; }

        public ApplicationUser User { get; set; }
    }
    public enum StudentStatus
    {
        Submitted,
        Approved,
        Rejected
    }

}
