using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class FinancialPeriodDtl
    {
        public int Id { get; set; }
        public int PeriodId { get; set; }
        public DateTime MonthFrom { get; set; }
        public DateTime MonthTo { get; set; }
        public bool PartialLock { get; set; }
        public bool CompleteLock { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual FinancialPeriodHdr Period { get; set; } = null!;
    }
}
