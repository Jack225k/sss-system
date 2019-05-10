
using System.ComponentModel.DataAnnotations;

namespace SSS_System.ViewModels
{
    public class InstallationViewModel
    {
        [Key]
        public int ReportID { get; set; }

        [Required(ErrorMessage = "Client Name is a required field.")]
        [Display(Name = "Client Name:")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Branch Name is a required field.")]
        [Display(Name = "Branch Name:")]
        public string BranchName { get; set; }

        [Required(ErrorMessage = "Branch Number is a required field.")]
        [Display(Name = "Branch Number:")]
        public string BranchNo { get; set; }

        [Required(ErrorMessage = "Address is a required field.")]
        [Display(Name = "Address:")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Store Manager is a required field.")]
        [Display(Name = "Store Manager:")]
        public string Store_Manager { get; set; }

        [Required(ErrorMessage = "Telephone Number is a required field.")]
        [Display(Name = "Telephone Number:")]
        public double Tel { get; set; }

        [Display(Name = "Fax Number:")]
        public double? Fax { get; set; }

        [Required(ErrorMessage = "*Please enter your email.")]
        [Display(Name = "Email Address:")]
        [EmailAddress]
        public string Email { get; set; }









        [Display(Name = "Type of Antennas:")]
        public string Type { get; set; }


        [Display(Name = "Antennas Serial Numbers(EM):")]
        public double? Antennas { get; set; }


        [Display(Name = "Serial Number Power Unit (EM):")]
        public double? Serial { get; set; }


        [Display(Name = "Mental Detector:")]
        public string Mental_Detector { get; set; }


        [Display(Name = "Remote Module Number:")]
        public string Remote { get; set; }







        [Display(Name = "Enterance 1 - Rx/Tx Config:")]
        public int? Enterance1 { get; set; }


        [Display(Name = "Distances Between:")]
        public double? Distance1 { get; set; }


        [Display(Name = "Enterance 2 - Rx/Tx Config:")]
        public int? Enterance2 { get; set; }


        [Display(Name = "Distances Between::")]
        public double? Distance2 { get; set; }


        [Display(Name = "Enterance 3 - Rx/Tx Config::")]
        public int? Enterance3 { get; set; }


        [Display(Name = "Distances Between:")]
        public double? Distance3 { get; set; }


        [Display(Name = "Enterance 4 - Rx/Tx Config::")]
        public int? Enterance4 { get; set; }


        [Display(Name = "Distances Between:")]
        public double? Distance4 { get; set; }




        [Required(ErrorMessage = "Quantity is a required field.")]
        [Display(Name = "Quanity:")]
        public int Q1 { get; set; }

        [Display(Name = "Make/Model:")]
        public string Make { get; set; }


        [Display(Name = "Lockable:")]
        public string Lockable { get; set; }




        [Required(ErrorMessage = "Quantity is a required field.")]
        [Display(Name = "Quantity:")]
        public int Q2 { get; set; }


        [Display(Name = "Strength:")]
        public string Strength { get; set; }







        [Display(Name = "Quantity #1:")]
        public int? TQ1 { get; set; }


        [Display(Name = "Type #1:")]
        public string TType1 { get; set; }


        [Display(Name = "Quantity #2:")]
        public int? TQ2 { get; set; }


        [Display(Name = "Type #2:")]
        public string TType2 { get; set; }



        [Display(Name = "Quantity #1:")]
        public int? TQ3 { get; set; }


        [Display(Name = "Type #1:")]
        public string TType3 { get; set; }


        [Display(Name = "Quantity #2:")]
        public int? TQ4 { get; set; }


        [Display(Name = "Type #2:")]
        public string TType4 { get; set; }







        [Display(Name = "Cables - Neat")]
        public bool Cable { get; set; }

        [Display(Name = "Grouting - Neat")]
        public bool Grouting { get; set; }

        [Display(Name = "Pedestals Property Upright")]
        public bool PPU { get; set; }

        [Display(Name = "Pedestals Property Aligned")]
        public bool PPA { get; set; }

        [Display(Name = "Power Points")]
        public bool Power_Points { get; set; }

        [Display(Name = "DB-Labelled")]
        public bool DB_Labelled { get; set; }

        [Display(Name = "Comments/Observation")]
        [DataType(DataType.MultilineText)]
        public string Comments1 { get; set; }





        [Display(Name = "Completion Photograph")]
        public string Completion { get; set; }

        [Display(Name = "Signed Cert. of Acceptance")]
        public string SinedC { get; set; }

        [Display(Name = "Signed Delivery Note")]
        public string SignedD { get; set; }

        [Display(Name = "Screen Shots")]
        public string Screen_Shots { get; set; }

        [Display(Name = "Staff Training Conduct")]
        public string Staff_Training_Conduct { get; set; }

        [Display(Name = "Comments/Observation")]
        [DataType(DataType.MultilineText)]
        public string Comment2 { get; set; }



        [Required(ErrorMessage = "Name is a required field.")]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Signature is a required field.")]
        [Display(Name = "Signature:")]
        public string Signature { get; set; }

        [Required(ErrorMessage = "Place is a required field.")]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        public System.DateTime? Date { get; set; }


    }
}