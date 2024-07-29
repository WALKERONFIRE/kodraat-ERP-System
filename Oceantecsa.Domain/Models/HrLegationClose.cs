using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLegationClose
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public string Reason { get; set; } = null!;
        public bool? Normal { get; set; }
        public int SalaryItem { get; set; }
        public float FValue { get; set; }
        public string FDesc { get; set; } = null!;
    }
}
