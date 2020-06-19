using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Operation_Logging.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Item Code")]
        public string ProductCode { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public string Manufacturer { get; set; }

        [Display(Name = "Shipping No")]
        public string ShippingNo { get; set; }

        [Display(Name = "Serial No")]
        public int SerialNo { get; set; }

        [Display(Name = "Batch No")]
        public string BatchNo { get; set; }

        [Display(Name = "Retail Price")]
        public decimal MRP { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Created On")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Modified On")]
        public DateTime? LastModifiedOn { get; set; }
    }
}
