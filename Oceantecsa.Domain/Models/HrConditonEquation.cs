using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrConditonEquation
    {
        public int FId { get; set; }
        public int SalaryItemId { get; set; }
        public string IfConditionVal { get; set; } = null!;
        public string IfConditionName { get; set; } = null!;
        public string IfConditionNameA { get; set; } = null!;
        public string Operator { get; set; } = null!;
        public string IfConditionVal1 { get; set; } = null!;
        public string IfConditionName1 { get; set; } = null!;
        public string IfConditionNameA1 { get; set; } = null!;
        public string ThenVal { get; set; } = null!;
        public string ThenName { get; set; } = null!;
        public string ThenNameA { get; set; } = null!;
        public float MaxVal { get; set; }
        public float MinVal { get; set; }
    }
}
