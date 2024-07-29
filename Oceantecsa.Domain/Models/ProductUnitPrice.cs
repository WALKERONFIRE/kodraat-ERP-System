using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class ProductUnitPrice
    {
        public ProductUnitPrice()
        {
            Products = new HashSet<Product>();
        }

        public int ProductUnitPriceId { get; set; }
        public long? ProductId { get; set; }
        public int? MeasurementUnitId { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? HalfWholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }

        public virtual MeasurementUnit? MeasurementUnit { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
