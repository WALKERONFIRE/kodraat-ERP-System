using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrOptionDtlLeave
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public float CalcHour { get; set; }
        public int ForMonth { get; set; }
        public bool CalcPolicyForHalfDay { get; set; }
    }
}
