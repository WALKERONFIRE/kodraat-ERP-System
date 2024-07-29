using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class TransactionOutDtl
    {
        public long TransactionOutHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
        public string ProductDescription { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual TransactionOutHdr TransactionOutHdr { get; set; } = null!;
    }
}
