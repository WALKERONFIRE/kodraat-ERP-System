using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEvalItem
    {
        public HrEvalItem()
        {
            HrEvalDeptItems = new HashSet<HrEvalDeptItem>();
            HrEvalDtls = new HashSet<HrEvalDtl>();
        }

        public int FId { get; set; }
        public string Fname { get; set; } = null!;
        public string FnameA { get; set; } = null!;
        public float EvalValMax { get; set; }
        public int DepartmentId { get; set; }

        public virtual ICollection<HrEvalDeptItem> HrEvalDeptItems { get; set; }
        public virtual ICollection<HrEvalDtl> HrEvalDtls { get; set; }
    }
}
