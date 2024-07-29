using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPdeptItemEmp
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
        public int EmpId { get; set; }
        public bool Apply { get; set; }
    }
}
