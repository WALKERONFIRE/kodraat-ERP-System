using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndServicePolicyHdr
    {
        public HrEndServicePolicyHdr()
        {
            HrEndServicePolicyDtls = new HashSet<HrEndServicePolicyDtl>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public bool DeductAbsentDaysWithPer { get; set; }
        public bool DeductAbsentDaysWithOutPer { get; set; }

        public virtual ICollection<HrEndServicePolicyDtl> HrEndServicePolicyDtls { get; set; }
    }
}
