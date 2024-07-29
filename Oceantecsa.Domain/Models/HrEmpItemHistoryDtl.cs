using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpItemHistoryDtl
    {
        public int FId { get; set; }
        public int FHdrId { get; set; }
        public int EmpId { get; set; }
        public decimal OldValue { get; set; }
        public decimal DtlVal { get; set; }
        public decimal? NewValue { get; set; }
        public short AddLess { get; set; }
        public bool App { get; set; }
        public bool IsSystem { get; set; }
        public float InsuranceVal { get; set; }
        public float InsuranceComp { get; set; }
        public int NotApp { get; set; }
        /// <summary>
        /// لاضافة الحقل إلى المجموع فى شاشة الربط
        /// </summary>
        public bool SumIt { get; set; }

        public virtual HrEmpItemHistoryHdr FHdr { get; set; } = null!;
    }
}
