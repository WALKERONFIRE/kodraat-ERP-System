using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrIncentiveHdr
    {
        public HrIncentiveHdr()
        {
            HrIncentiveDtls = new HashSet<HrIncentiveDtl>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrIncentiveDtl> HrIncentiveDtls { get; set; }
    }
}
