using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirstApproch.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? SalePrice { get; set; }
        public int? PurchasePrice { get; set; }
    }
}
