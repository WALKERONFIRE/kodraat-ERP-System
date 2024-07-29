using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPperiod
    {
        /// <summary>
        /// الفترات
        /// </summary>
        public int PeriodId { get; set; }
        public float PeriodFrom { get; set; }
        public float PeriodTo { get; set; }
        public string FDesc { get; set; } = null!;
    }
}
