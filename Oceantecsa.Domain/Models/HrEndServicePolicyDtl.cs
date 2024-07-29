using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndServicePolicyDtl
    {
        public int FId { get; set; }
        public int EndServiceHdr { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public float FValue { get; set; }

        public virtual HrEndServicePolicyHdr EndServiceHdrNavigation { get; set; } = null!;
    }
}
