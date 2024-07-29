using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpVacType
    {
        public int EmpId { get; set; }
        public int TypeId { get; set; }
        public float FValue { get; set; }
        public bool? App { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrVacType Type { get; set; } = null!;
    }
}
