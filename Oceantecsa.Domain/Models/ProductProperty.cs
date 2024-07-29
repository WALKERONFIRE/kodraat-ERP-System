using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class ProductProperty
    {
        public int ProductPropertiesId { get; set; }
        public long? ProductId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int OrderLimit { get; set; }
        public int MaximumLimit { get; set; }
        public int MinimumLimit { get; set; }
        public decimal LastPurchasePrice { get; set; }
        public decimal ProductWidth { get; set; }
        public decimal ProductHeight { get; set; }

        public virtual Product? Product { get; set; }
    }
}
