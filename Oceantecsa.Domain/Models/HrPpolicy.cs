using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPpolicy
    {
        public HrPpolicy()
        {
            HrPdeptItems = new HashSet<HrPdeptItem>();
            HrPtimesPeriods = new HashSet<HrPtimesPeriod>();
        }

        public int PolicyId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        /// <summary>
        /// 0 for Late and 1 for Over time 2 for Absence without permission 3 for Attend in Holiday  4 for Permission Delay 5 for Mission Delay 20 for absent without permission 7 For Leave Befor Time
        /// </summary>
        public int PolicyType { get; set; }
        /// <summary>
        /// Allowance in Minutes for policy
        /// </summary>
        public int Allowance { get; set; }
        public bool AllowFraction { get; set; }
        public string FDesc { get; set; } = null!;
        /// <summary>
        /// if 1 then delay only with Policy_type 0 ignore department relation
        /// </summary>
        public bool EffectInLeaves { get; set; }

        public virtual ICollection<HrPdeptItem> HrPdeptItems { get; set; }
        public virtual ICollection<HrPtimesPeriod> HrPtimesPeriods { get; set; }
    }
}
