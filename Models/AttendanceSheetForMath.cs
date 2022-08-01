using System.ComponentModel.DataAnnotations;

namespace SerpantWebApp.Models
{
    public class AttendanceSheetForMath
    {
        [Key]
        public int LessonSessionID { get; set; }
        public string CourseTitle { get; set; }

        public string StaffName { get; set; }

        /*
         
        In the database, an Enrollment row is related to a Student row if its StudentID column contains the student's ID value.
        For example, suppose a Student row has ID=1. Related Enrollment rows will have StudentID = 1. StudentID is a 
        foreign key in the Enrollment table.
         
         */
        public string StudentName { get; set; }

        /*
         
        The Grade property is an enum. The question mark after the Grade type declaration indicates that the Grade property is nullable.
        A grade that's null is different from a zero grade—null means a grade isn't known or hasn't been assigned yet.
         */
        public bool Presence { get; set; }
    }
}
