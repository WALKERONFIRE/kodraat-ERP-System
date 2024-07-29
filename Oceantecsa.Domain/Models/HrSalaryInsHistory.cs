using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryInsHistory
    {
        public int FId { get; set; }
        public int FYear { get; set; }
        public float FPercent { get; set; }
        public int EmpId { get; set; }
        public float LastBasicInsSalary { get; set; }
    }
}
