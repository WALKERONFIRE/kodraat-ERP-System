using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class MeasurementUnit
    {
        public MeasurementUnit()
        {
            ProductUnitPrices = new HashSet<ProductUnitPrice>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? ProductUnitPriceId { get; set; }

        public virtual ICollection<ProductUnitPrice> ProductUnitPrices { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
