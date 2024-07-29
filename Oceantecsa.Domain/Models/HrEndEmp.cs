using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndEmp
    {
        public HrEndEmp()
        {
            HrEmpConcerneds = new HashSet<HrEmpConcerned>();
        }

        public int EmpId { get; set; }
        public DateTime FDate { get; set; }
        public string FReason { get; set; } = null!;
        public int TypeId { get; set; }
        public DateTime EndInsDate { get; set; }

        public virtual ICollection<HrEmpConcerned> HrEmpConcerneds { get; set; }
    }
}
