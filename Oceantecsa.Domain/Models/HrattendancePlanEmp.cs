using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrattendancePlanEmp
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public int GroupId { get; set; }
        public DateTime FDate { get; set; }
        public string AttPlanDtlFromHour { get; set; } = null!;
        public string AttPlanDtlToHour { get; set; } = null!;
        public bool? Attend { get; set; }
        public string AttPlanDtlFromHour1 { get; set; } = null!;
        public string AttPlanDtlToHour1 { get; set; } = null!;
    }
}
