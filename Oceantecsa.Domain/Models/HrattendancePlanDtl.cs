using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrattendancePlanDtl
    {
        public int AttPlanDtlId { get; set; }
        public int AttPlanDtlHdrid { get; set; }
        public int AttPlanDtlGroupId { get; set; }
        public string AttPlanDtlFromHour { get; set; } = null!;
        public string AttPlanDtlToHour { get; set; } = null!;
        public string AttPlanDtlDelayTime { get; set; } = null!;
        public string AttPlanDtlOverTime { get; set; } = null!;
        public string AttPlanDtlDesc { get; set; } = null!;
        public string AttPlanDtlFromHour1 { get; set; } = null!;
        public string AttPlanDtlToHour1 { get; set; } = null!;
        public float CalcWorkHour { get; set; }

        public virtual HrattendancePlanHdr AttPlanDtlHdr { get; set; } = null!;
    }
}
