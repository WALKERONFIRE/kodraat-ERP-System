using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrAdm
    {
        public int Fid { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? ArriveTime { get; set; }
        public DateTime DelayTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public DateTime OverTime { get; set; }
        public int OverTimeItem { get; set; }
        public int DelayItem { get; set; }
        public int AbsentItem { get; set; }
        public int ReplcVacItem { get; set; }
        public int VacCalcType { get; set; }
        public int UnpaidVacItem { get; set; }
        public int DefaultEmpStatus { get; set; }

        public virtual HrDepartment Department { get; set; } = null!;
    }
}
