using System;
using System.Collections.Generic;

namespace DatabaseFirstApproch.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ProductId { get; set; }
    }
}
