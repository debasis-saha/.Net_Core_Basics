using System;
using System.ComponentModel.DataAnnotations;

namespace SampleCoreEFPrjects.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Display(Name = "Product Code")]
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
