using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrDepartmentSectionJob
    {
        public int SectionId { get; set; }
        public int JobId { get; set; }
        public int EmpCount { get; set; }

        public virtual HrJob Job { get; set; } = null!;
        public virtual HrDepartmentSection Section { get; set; } = null!;
    }
}
