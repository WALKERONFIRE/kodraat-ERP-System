using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrBoundDegree
    {
        public int DegreeId { get; set; }
        public int BoundCode { get; set; }
        public float FValue { get; set; }

        public virtual HrSalaryBound BoundCodeNavigation { get; set; } = null!;
        public virtual HrJobDegree Degree { get; set; } = null!;
    }
}
