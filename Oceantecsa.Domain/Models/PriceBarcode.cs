using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PriceBarcode
    {
        public int Id { get; set; }
        public long ProductsId { get; set; }
        public string MeasurementUnitsId { get; set; } = null!;
        public string? Barcode { get; set; }
        public double? WhPrice { get; set; }
        public double? Hwprice { get; set; }
        public double? Cprice { get; set; }
        public double? Dprice { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
