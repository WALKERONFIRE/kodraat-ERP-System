using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            Sections = new HashSet<Section>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public long CostCenterId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
