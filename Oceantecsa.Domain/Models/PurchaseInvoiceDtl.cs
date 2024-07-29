﻿using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseInvoiceDtl
    {
        public PurchaseInvoiceDtl()
        {
            PurchaseReturnDtls = new HashSet<PurchaseReturnDtl>();
        }

        public long PurchaseInvoiceHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal NetValue { get; set; }
        public decimal VatPercent { get; set; }
        public decimal VatValue { get; set; }
        public decimal TotalValue { get; set; }
        public string ProductDescription { get; set; } = null!;
        public decimal ReturnedQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public int Id { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual PurchaseInvoiceHdr PurchaseInvoiceHdr { get; set; } = null!;
        public virtual ICollection<PurchaseReturnDtl> PurchaseReturnDtls { get; set; }
    }
}
