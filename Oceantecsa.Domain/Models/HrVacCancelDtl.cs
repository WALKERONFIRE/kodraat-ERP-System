using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacCancelDtl
    {
        public int FId { get; set; }
        public int VacAddId { get; set; }
        public DateTime VacDate { get; set; }
        public bool Canceld { get; set; }
        public bool IsVacation { get; set; }
        public float ValueOfDay { get; set; }
        public bool IsWeekend { get; set; }
        /// <summary>
        /// 1 Begining of day 0 for End of day
        /// </summary>
        public bool DayDescription { get; set; }

        public virtual HrVacAdd VacAdd { get; set; } = null!;
    }
}
