using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryWithCurrency
    {
        public int FId { get; set; }
        public int SalaryId { get; set; }
        public int EmpId { get; set; }
        public int FCurCode { get; set; }
        public string FCatName { get; set; } = null!;
        public float FValue { get; set; }
        public float FCount { get; set; }
    }
}
