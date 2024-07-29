using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrHoliday
    {
        public int FId { get; set; }
        public int FYear { get; set; }
        public int FMonth { get; set; }
        public int FDay { get; set; }
        public bool FValue { get; set; }
        /// <summary>
        /// 0 for Holidays , 1 for WeekEnd
        /// </summary>
        public int FType { get; set; }
        public string FDesc { get; set; } = null!;
    }
}
