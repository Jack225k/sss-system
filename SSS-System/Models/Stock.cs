using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SSS_System.Models
{
    public class Stock
    {
        [Key]
        [DisplayName("Product ID")]
        public int Id { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Cost Price")]
        public double CostPrice { get; set; }

        [DisplayName("Selling Price")]
        public double SellingPrice { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        public string Dir { get; set; }
    }
}