using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Company_devices.Models
{
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int deviceID { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [Required]
        [DisplayName("Mac Address")]
        public int macD { get; set; }
        [Required]
        [DisplayName("Seriel Number")]
        public string SerialNumber { get; set; }
        [Required]
        [DisplayName("Vendor")]
        public string Vendor { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; } = "Assigned";
        public int majorId { get; set; }
        public int minorId { get; set; }
        public DateTime date_create { get; set; } = DateTime.Now;
        [Display(Name = "Employee")]
        public int Empid { get; set; }
        [ForeignKey("Empid")]
        public virtual Employee Employee { get; set; }
    }
}
