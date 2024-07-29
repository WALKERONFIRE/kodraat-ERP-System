using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseReturnDtl
    {
        public long PurchaseReturnHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal ReturnedQuantity { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
        public int? PurchaseInvoiceDtlId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual PurchaseInvoiceDtl? PurchaseInvoiceDtl { get; set; }
        public virtual PurchaseReturnHdr PurchaseReturnHdr { get; set; } = null!;
    }
}
