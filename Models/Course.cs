using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerpantWebApp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 6)]
        public int Credits { get; set; }

        public byte[] File { get; set; }
        public string FilePath { get; set; }

        /* public int TeacherID { get; set; }


         public Teacher Teacher { get; set; }*/

        public ICollection<Attendance> Attendances { get; set; }
    }
}
