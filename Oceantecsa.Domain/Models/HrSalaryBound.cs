using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryBound
    {
        public HrSalaryBound()
        {
            HrBoundDegrees = new HashSet<HrBoundDegree>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrBoundDegree> HrBoundDegrees { get; set; }
    }
}
