using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSS_System.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Client Reference is a required field")]
        [Display(Name = "Client Reference:")]
        public string ClientReference { get; set; }
        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Client Name is a required field")]
        public string Client { get; set; }

        [Required(ErrorMessage = "*Please enter your email.")]
        [Display(Name = "Email Address:")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Contact Person:")]
        public string ContactPerson { get; set; }
        [Display(Name = "Telephone:")]
        public double Telephone { get; set; }
        [Required(ErrorMessage = "Site Location is a required field")]
        [Display(Name = "Site Location:")]
        public string SiteLocation { get; set; }
        [Required(ErrorMessage = "Door Type is a required field")]
        [Display(Name = "Door Type:")]
        public string DoorType { get; set; }



        public bool Service { get; set; }
        [Display(Name = "Call out")]
        public bool Callout { get; set; }
        public bool Installation { get; set; }
        public bool Supply { get; set; }
        [Display(Name = "Work Carried Out:")]
        [DataType(DataType.MultilineText)]
        public string WCO { get; set; }
        [Display(Name = "Reason For Call-out:")]
        [DataType(DataType.MultilineText)]
        public string Reason { get; set; }
        [Display(Name = "Comments:")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }



        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        public DateTime? DateA { get; set; }
        [Display(Name = "Arrival Time:")]
        [DataType(DataType.Time)]
        public DateTime? ArrivalA { get; set; }
        [Display(Name = "Departure Time:")]
        [DataType(DataType.Time)]
        public System.DateTime? DepartureA { get; set; }
        //[Display(Name = "Hours:")]
        //public double? HoursA { get; set; }
        [Display(Name = "Total:")]
        public double? TotalA { get; set; }

        

        [Display(Name = "Travelling:")]
        public string Travelling { get; set; }
        [Display(Name = "KM:")]
        public int? Km { get; set; }
        [Display(Name = "TOTAL:")]
        public double? TotalD { get; set; }


        [Display(Name = "#1 Quanity:")]
        public int QuanityA { get; set; }
        [Display(Name = "#1 Total:")]
        public double TotalQA { get; set; }
        [Display(Name = "#2 Quanity:")]
        public int QuanityB { get; set; }
        [Display(Name = "#2 Total:")]
        public double TotalQB { get; set; }
        [Display(Name = "#3 Quanity:")]
        public int QuanityC { get; set; }
        [Display(Name = "#3 Total:")]
        public double TotalQC { get; set; }
        [Display(Name = "#4 Quanity:")]
        public int QuanityD { get; set; }
        [Display(Name = "#4 Total:")]
        public double TotalQE { get; set; }

        [Display(Name = "Sub Total:")]
        public double? SubTotal { get; set; }
        [Display(Name = "VAT:")]
        public double? Vat { get; set; }
        [Display(Name = "Grand Total:")]
        public double? GrandTotal { get; set; }

        [Required(ErrorMessage = "Technician name is a required field.")]
        [Display(Name = "Technican:")]
        public string Technican { get; set; }
        [Display(Name = "Date Completed:")]
        [DataType(DataType.Date)]
        public DateTime? DateCompleted { get; set; }
        [Display(Name = "Signature:")]
        public string Signature { get; set; }


        [Required(ErrorMessage = "Name is a required field.")]
        [Display(Name = "Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Designation is a required field.")]
        [Display(Name = "Designation:")]
        public string Designation { get; set; }
        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        public DateTime? Dater { get; set; }
        [Display(Name = "Time:")]
        [DataType(DataType.Time)]
        public DateTime? Time { get; set; }
        [Display(Name = "Signature:")]
        public string SignatureB { get; set; }


        public double CalcSubTotal()
        {
            double tt = 0.0;
            tt = (TotalQA + TotalQB + TotalQC + TotalQE);
            return tt;
        }

        

        public double CalcVat()
        {
            double vt = 0.0;
            vt = (CalcSubTotal() * 0.14);
            return vt;
        }


        public double CalcGrandTotal()
        {
            double gt = 0.0;
            gt = CalcSubTotal() + CalcVat();
            return gt;
        }
    }
}