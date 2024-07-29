using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrIncentiveSalaryDtl
    {
        public int FId { get; set; }
        public int FHdr { get; set; }
        public int EmpCode { get; set; }

        public virtual HrIncentiveSalaryHdr FHdrNavigation { get; set; } = null!;
    }
}
