using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPtimesPeriod
    {
        public int PolicyId { get; set; }
        public int TimeId { get; set; }
        public int PeriodId { get; set; }
        public float TimeValue { get; set; }
        public float MaxTimeCalc { get; set; }

        public virtual HrPpolicy Policy { get; set; } = null!;
        public virtual HrPtime Time { get; set; } = null!;
    }
}
