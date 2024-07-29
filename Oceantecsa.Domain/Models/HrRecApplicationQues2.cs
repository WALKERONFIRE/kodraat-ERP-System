using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecApplicationQues2
    {
        public int FId { get; set; }
        public int JobApplicationId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompJob { get; set; } = null!;
        public float Salary { get; set; }
        public DateTime WorkFrom { get; set; }
        public DateTime WorkTo { get; set; }
        public float PeriodService { get; set; }
        public string LeaveworkReason { get; set; } = null!;
        public string ManagerName { get; set; } = null!;
        public string CompTel { get; set; } = null!;

        public virtual HrRecJobApplication JobApplication { get; set; } = null!;
    }
}
