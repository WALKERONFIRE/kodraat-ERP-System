using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrDepartment
    {
        public HrDepartment()
        {
            HrDepartmentSections = new HashSet<HrDepartmentSection>();
            HrEvalDeptItems = new HashSet<HrEvalDeptItem>();
            HrPdeptItems = new HashSet<HrPdeptItem>();
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int DepartmentId { get; set; }
        public string Fname { get; set; } = null!;
        public string FnameA { get; set; } = null!;
        public int CompId { get; set; }
        public int BranchId { get; set; }
        public long InsuranceShare { get; set; }
        public int EmpCount { get; set; }

        public virtual ICollection<HrDepartmentSection> HrDepartmentSections { get; set; }
        public virtual ICollection<HrEvalDeptItem> HrEvalDeptItems { get; set; }
        public virtual ICollection<HrPdeptItem> HrPdeptItems { get; set; }
        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
