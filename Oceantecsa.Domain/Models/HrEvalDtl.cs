using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEvalDtl
    {
        public int EvalHdr { get; set; }
        public int EmpId { get; set; }
        public int EvalId { get; set; }
        public float EvalValMax { get; set; }
        public float EvalVal { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrEvalItem Eval { get; set; } = null!;
        public virtual HrEvalHdr EvalHdrNavigation { get; set; } = null!;
    }
}
