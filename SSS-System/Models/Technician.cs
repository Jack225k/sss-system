using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SSS_System.Models
{
    public class Technician
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string TechFullName { get; set; }

        [Display(Name = "Identity Number")]
        public string IdNumber { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Area")]
        public string Area { get; set; }

        public virtual Area Areas { get; set; }
    }
}