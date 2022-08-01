using System;
using System.Collections.Generic;

namespace DatabaseFirstApproch.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? SalePrice { get; set; }
        public int? PurchasePrice { get; set; }
    }
}
