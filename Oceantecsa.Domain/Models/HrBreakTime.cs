using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrBreakTime
    {
        public int FId { get; set; }
        public DateTime FDate { get; set; }
        public int GroupId { get; set; }
        public int BreakId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
    }
}
