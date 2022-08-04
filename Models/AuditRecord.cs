using System;
using System.ComponentModel.DataAnnotations;

namespace SerpantWebApp.Models
{
    public class AuditRecord
    {
        [Key]
        public int AuditID { get; set; }
        [Display(Name = "Audit Action : ")]
        public string AuditActionType { get; set; }

        [Display(Name = "Performed By : ")]
        public string Username { get; set; }

        [Display(Name = "Data | Time Stamp : ")]
        [DataType(DataType.DateTime)]
        public DateTime DateTimeStamp { get; set; }

        [Display(Name = "Product Record ID : ")]
        public int KeyProductFieldID { get; set; }

        [Display(Name = "Role Record ID : ")]
        public int KeyRoleFieldID { get; set; }

        

    }
}
