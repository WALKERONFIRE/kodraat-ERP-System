using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndServiceBonusSpecificDtl
    {
        public int DtlId { get; set; }
        public int HdrId { get; set; }
        public int EmpId { get; set; }
        public float EndSerSalaryItem { get; set; }
        public float YearlySpecific { get; set; }
        public float MonthlySpecific { get; set; }
        public bool Specific { get; set; }

        public virtual HrEndServiceBonusSpecificHdr Hdr { get; set; } = null!;
    }
}
