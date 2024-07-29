using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLegationDtl
    {
        public int FId { get; set; }
        public int IdHdr { get; set; }
        public int CostId { get; set; }
        public float FValue { get; set; }
        public bool FPayed { get; set; }

        public virtual HrLegationHdr IdHdrNavigation { get; set; } = null!;
    }
}
