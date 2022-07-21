using System;
using System.ComponentModel.DataAnnotations;

namespace SerpantWebApp.Models
{
    public class Classrooms
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Block { get; set; }
        public int Unit { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TimeSlot { get; set; }

    }
}
