using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrIncentiveDtl
    {
        public int FId { get; set; }
        public int FIdhdr { get; set; }
        public float FromVal { get; set; }
        public float Toval { get; set; }
        public float FValue { get; set; }

        public virtual HrIncentiveHdr FIdhdrNavigation { get; set; } = null!;
    }
}
