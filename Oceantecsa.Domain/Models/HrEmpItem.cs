using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpItem
    {
        public int Fid { get; set; }
        public int EmpId { get; set; }
        public int ItemId { get; set; }
        public decimal FValue { get; set; }
        public short AddLess { get; set; }
        public bool App { get; set; }
        public bool IsSystem { get; set; }
        public float InsuranceVal { get; set; }
        public float InsuranceComp { get; set; }
        public int NotApp { get; set; }
        /// <summary>
        /// لاضافة الحقل إلى المجموع فى شاشة الربط
        /// </summary>
        public bool SumIt { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrSalaryItem Item { get; set; } = null!;
    }
}
