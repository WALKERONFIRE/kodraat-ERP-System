using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrWeekEnd
    {
        public int FYear { get; set; }
        public bool Sat { get; set; }
        public bool Sun { get; set; }
        public bool Mon { get; set; }
        public bool Tues { get; set; }
        public bool Wed { get; set; }
        public bool Thur { get; set; }
        public bool Fri { get; set; }
    }
}
