using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrIncentiveSalaryHdr
    {
        public HrIncentiveSalaryHdr()
        {
            HrIncentiveSalaryDtls = new HashSet<HrIncentiveSalaryDtl>();
        }

        public int FId { get; set; }
        public float FValue { get; set; }
        public float MinumLimit { get; set; }
        public float AbsValue { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrIncentiveSalaryDtl> HrIncentiveSalaryDtls { get; set; }
    }
}
