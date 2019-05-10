using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSS_System.Models
{
    public class Area
    {
        [Key]
        //Note: Entity framework automatically resolves Id to AreaId as a Partial Key.
        public int Id { get; set; }
        //
        [Display(Name = "Area Name")]
        public string AreaName { get; set; }
    }
}