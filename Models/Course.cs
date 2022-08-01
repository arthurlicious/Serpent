using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public string TeacherID { get; set; }


        public Teacher Teacher { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
    }
}
