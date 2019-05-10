using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSS_System.Models
{
    public class ExpertiseField
    {
        [Key]
        public int Id { get; set; }
        public string FieldExpertise { get; set; }
    }
}