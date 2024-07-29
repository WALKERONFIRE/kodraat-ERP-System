using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrattendancePlanHdr
    {
        public HrattendancePlanHdr()
        {
            HrattendancePlanDtls = new HashSet<HrattendancePlanDtl>();
        }

        public int AttPlanHdrId { get; set; }
        public string? AttPlanHdrCode { get; set; }
        public DateTime? AttPlanHdrFromDate { get; set; }
        public DateTime? AttPlanHdrToDate { get; set; }
        public string? AttPlanHdrDesc { get; set; }
        public int OptionId { get; set; }
        public bool FPost { get; set; }

        public virtual ICollection<HrattendancePlanDtl> HrattendancePlanDtls { get; set; }
    }
}
