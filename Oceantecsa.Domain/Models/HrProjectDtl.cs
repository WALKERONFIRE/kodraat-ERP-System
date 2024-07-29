using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrProjectDtl
    {
        public int FId { get; set; }
        public int FHdr { get; set; }
        public string SubLocation { get; set; } = null!;
        public int CostCenterId { get; set; }

        public virtual HrProjectHdr FHdrNavigation { get; set; } = null!;
    }
}
