using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Drivers = new HashSet<Driver>();
            Salesmen = new HashSet<Salesman>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual Section Section { get; set; } = null!;
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Salesman> Salesmen { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
