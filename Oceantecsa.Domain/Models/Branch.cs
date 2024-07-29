using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Branch
    {
        public Branch()
        {
            CashBoxes = new HashSet<CashBox>();
            Employees = new HashSet<Employee>();
            UserBranches = new HashSet<UserBranch>();
            Users = new HashSet<User>();
            Warehouses = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishAddress { get; set; } = null!;
        public string ArabicAddress { get; set; } = null!;
        public string TelephoneNo1 { get; set; } = null!;
        public string TelephoneNo2 { get; set; } = null!;
        public string TelephoneNo3 { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CityId { get; set; }
        public bool HeadOffice { get; set; }
        public bool IsFactory { get; set; }
        public bool IsShowRoom { get; set; }
        public long CostCenterId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<CashBox> CashBoxes { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<UserBranch> UserBranches { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
