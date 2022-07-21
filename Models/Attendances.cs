using System;
using System.ComponentModel.DataAnnotations;

namespace SerpantWebApp.Models
{
    public class Attendances
    {
        [Key]
        public int SID { get; set; }
        public string FullName { get; set; }
        public bool presence { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
