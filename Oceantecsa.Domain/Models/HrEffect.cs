using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEffect
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public DateTime FDate { get; set; }
        public int SalaryItemId { get; set; }
        public float FValue { get; set; }
        public int FType { get; set; }
    }
}
