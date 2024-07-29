using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Section
    {
        public Section()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public long CostCenterId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
