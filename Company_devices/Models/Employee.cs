using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Company_devices.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Empid { get; set; }

        [Required(ErrorMessage = "First Name field is required")]
        [DisplayName("First Name")]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [StringLength(60)]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Gender is required")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        //[Required(ErrorMessage = "Identity Number/ Passport Number is required")]
        [DisplayName("Identity/Passport Number")]
        [RegularExpression(@"\d{8,13}", ErrorMessage = "Identity Number or Passport Number must be between 8 & 13 digits")]
        public Int64? IdNumber { get; set; }

        //[Required(ErrorMessage = "Ethnicity is required")]
        [DisplayName("Ethnicity")]
        [StringLength(20)]
        public string Ethnicity { get; set; }

        [DisplayName(" Position")]
        public string Position { get; set; }

        [Display(Name = " Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\d{10,10}", ErrorMessage = "Contact must be 10 digits")]
        public string AlternativeContact { get; set; }

        //[Required(ErrorMessage = "Address is required")]

        [StringLength(25, ErrorMessage = "Street Name must be not more than 25 characters")]
        public string Address { get; set; }

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

        //[Required(ErrorMessage = "Selection of Province is mandatory")]
        [StringLength(40)]
        public string Province { get; set; }

        //public virtual ICollection<Device> Device { get; set; }

        public int id { get; set; }
        [ForeignKey("id")]
        public virtual Company Company { get; set; }
    }
}
