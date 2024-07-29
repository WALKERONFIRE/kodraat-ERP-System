using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class TransactionInDtl
    {
        public long TransactionInHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
        public string ProductDescription { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual TransactionInHdr TransactionInHdr { get; set; } = null!;
    }
}
