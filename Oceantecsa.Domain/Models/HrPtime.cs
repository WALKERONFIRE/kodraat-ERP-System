using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPtime
    {
        public HrPtime()
        {
            HrPtimesPeriods = new HashSet<HrPtimesPeriod>();
        }

        public int TimeId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrPtimesPeriod> HrPtimesPeriods { get; set; }
    }
}
