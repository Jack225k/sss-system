using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSS_System.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Display(Name = "Customer Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter customer email.")]
        [Display(Name = "Email Address:")]
        [EmailAddress]
        public string Customer_email { get; set; }
        public string Industry { get; set; }
        public string Client { get; set; }
        [Display(Name = "Contact Name")]
        public string Contact_Name { get; set; }
        [Required(ErrorMessage = "Contact number is a required field")]
        [MaxLength(10, ErrorMessage = "Maximum length is 10"), MinLength(10, ErrorMessage = "Minimum length is 10")]
        [Display(Name = "Contact Number")]
        public string Contact_Number { get; set; }
        [Required(ErrorMessage = "*Please enter contact email.")]
        [Display(Name = "Email Address:")]
        [EmailAddress]
        public string Contact_Email { get; set; }

        [Required(ErrorMessage = "*Please select if there is a Contract in place .")]
        [Display(Name = " Maintenance Contract")]
        public string MaintenanceContract { get; set; }

        [Display(Name = "Contract Duration")]
        public int ContractDuration { get; set; }

        [Display(Name = "Services Per a Month")]
        public string ServicesPerMonth { get; set; }
    }
}