using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEvalDeptItem
    {
        public int DepartmentId { get; set; }
        public int EvalId { get; set; }
        public float EvalValMax { get; set; }
        public int ItemId { get; set; }

        public virtual HrDepartment Department { get; set; } = null!;
        public virtual HrEvalItem Eval { get; set; } = null!;
    }
}
