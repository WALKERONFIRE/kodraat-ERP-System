using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseOrderDtl
    {
        public int OrderId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public long ProductId { get; set; }

        public virtual PurchaseOrderHdr Order { get; set; } = null!;
    }
}
