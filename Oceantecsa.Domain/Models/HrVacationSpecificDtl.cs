using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacationSpecificDtl
    {
        public int DtlId { get; set; }
        public int HdrId { get; set; }
        public int EmpId { get; set; }
        public float VacDayCount { get; set; }
        public float SalaryItemValue { get; set; }
        public float YearlySpecific { get; set; }
        public float MonthlySpecific { get; set; }
        public bool Specific { get; set; }

        public virtual HrVacationSpecificHdr Hdr { get; set; } = null!;
    }
}
