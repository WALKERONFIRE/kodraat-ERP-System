using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLogInfo
    {
        public long LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int EmpId { get; set; }
        public DateTime? ArriveAt { get; set; }
        public DateTime? LeaveAt { get; set; }
        public string Description { get; set; } = null!;
        public int RegIn { get; set; }
        public int StatusId { get; set; }
        public DateTime ArriveTime { get; set; }
        public DateTime DelayTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public DateTime OverTime { get; set; }
        public int GroupId { get; set; }
        public int AttendPlanId { get; set; }
        public int? WorkMinutes { get; set; }
        public string AbsentReason { get; set; } = null!;
        public DateTime ArriveTime1 { get; set; }
        public DateTime LeaveTime1 { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
    }
}
