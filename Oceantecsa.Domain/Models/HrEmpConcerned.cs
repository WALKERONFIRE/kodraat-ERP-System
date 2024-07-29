using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpConcerned
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public int ConcerId { get; set; }
        public bool Complete { get; set; }

        public virtual HrEndEmp Emp { get; set; } = null!;
    }
}
