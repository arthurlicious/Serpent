using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    /*public enum Presence
    {
        T, F
    }*/

    public class Attendance
    {
        [Key]
        public int LessonSessionID { get; set; }
        public int CourseID { get; set; }

        /*
         
        In the database, an Enrollment row is related to a Student row if its StudentID column contains the student's ID value.
        For example, suppose a Student row has ID=1. Related Enrollment rows will have StudentID = 1. StudentID is a 
        foreign key in the Enrollment table.
         
         */
        public int StudentID { get; set; }
        public int TeacherID { get; set; }

        /*
         
        The Grade property is an enum. The question mark after the Grade type declaration indicates that the Grade property is nullable.
        A grade that's null is different from a zero grade—null means a grade isn't known or hasn't been assigned yet.
         */
        public bool Presence { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
