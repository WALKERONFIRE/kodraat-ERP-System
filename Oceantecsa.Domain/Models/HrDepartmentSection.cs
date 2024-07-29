using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrDepartmentSection
    {
        public HrDepartmentSection()
        {
            HrDepartmentSectionJobs = new HashSet<HrDepartmentSectionJob>();
        }

        public int SectionId { get; set; }
        public string FName { get; set; } = null!;
        public string FNamea { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int CostCenterId { get; set; }

        public virtual HrDepartment Department { get; set; } = null!;
        public virtual ICollection<HrDepartmentSectionJob> HrDepartmentSectionJobs { get; set; }
    }
}
