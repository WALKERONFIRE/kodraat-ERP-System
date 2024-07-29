using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrProjectHourDistDtl
    {
        public int FId { get; set; }
        public int FHdrId { get; set; }
        public int CostCenterId { get; set; }
        public float FValue { get; set; }

        public virtual HrProjectHourDistHdr FHdr { get; set; } = null!;
    }
}
