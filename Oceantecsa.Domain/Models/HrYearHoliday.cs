using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrYearHoliday
    {
        public int FId { get; set; }
        public string DayDesc { get; set; } = null!;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
