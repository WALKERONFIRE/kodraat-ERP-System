using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPdeptItem
    {
        /// <summary>
        /// Policy ID in HrPPolicy
        /// </summary>
        public int PolicyId { get; set; }
        /// <summary>
        /// Department Id in HrDepartment
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// Salry Item ID in HrSalaryItem table
        /// </summary>
        public int ItemId { get; set; }

        public virtual HrDepartment Department { get; set; } = null!;
        public virtual HrSalaryItem Item { get; set; } = null!;
        public virtual HrPpolicy Policy { get; set; } = null!;
    }
}
