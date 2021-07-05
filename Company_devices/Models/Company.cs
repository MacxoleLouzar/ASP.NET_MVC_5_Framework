using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Company_devices.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }
        [Required]
        [Display(Name = "Enterprise Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(12)]
        [MinLength(12)]
        public String RegistrationNO { get; set; }
        [Required]
        [Display(Name = "Company Director")]
        public String Director { get; set; }
        [Required]
        [Display(Name = "Telphone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [MinLength(10)]
        public String TelphoneNumber { get; set; }

        [Display(Name = "Cellphone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [MinLength(10)]
        public String CellphoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public String email { get; set; }


        // ---------------Physical Address-----------------
        [DisplayName("Unit Number")]
        [StringLength(25, ErrorMessage = "Street Name must be not more than 25 characters")]
        public string Address { get; set; }
        [DisplayName("Complex Name")]
        public string ComplexName { get; set; }
        [DisplayName("Street Name")]
        [StringLength(25, ErrorMessage = "Street Name must not be more than 25 characters")]
        public string StreetName { get; set; }

        [DisplayName("Surburb")]
        public string Surburb { get; set; }
        //[Required(ErrorMessage = "City is required")]
        [StringLength(60)]
        public string City { get; set; }
        //[Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("Postal Code")]
        [RegularExpression(@"\d{4,4}", ErrorMessage = "postal Code must be 4 digits")]
        public int? PostalCode { get; set; }

        [Display(Name = "Company Logo")]
        public byte[] image { get; set; }



        // ---------------Postal Address-----------------
        [DisplayName("Addrees Line 1")]
        public string Addrees1 { get; set; }
        [DisplayName("Addrees Line 2")]
        public string Addrees2 { get; set; }
        [DisplayName("Addrees Line 3")]
        public string Addrees3 { get; set; }
        [DisplayName("City")]
        public string Addrees4 { get; set; }
        [DisplayName("Postal Code")]
        [RegularExpression(@"\d{4,4}", ErrorMessage = "postal Code must be 4 digits")]
        public string Addrees5 { get; set; }

        //  public int Empid { get; set; }
        //[ForeignKey("Empid")]
        //public virtual ICollection<Employee> Employees { get; set; }
    }
}
