using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpInCallSett
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public float HoursCountNotAtt { get; set; }
        public float HourValAtt { get; set; }
    }
}
