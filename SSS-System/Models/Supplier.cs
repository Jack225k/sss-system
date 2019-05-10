using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSS_System.Models
{
    public class Supplier
    {
        [Key]
        [Display(Name = "Supplier ID")]
        public int Id { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Supplier Contact")]
        public int SupplierContact { get; set; }

        [Required(ErrorMessage = "*Please enter supplier email.")]
        [Display(Name = "Email Address:")]
        [EmailAddress]
        public string SupplierEmail { get; set; }

        [Display(Name = "Products")]
        public string Products { get; set; }
    }
}