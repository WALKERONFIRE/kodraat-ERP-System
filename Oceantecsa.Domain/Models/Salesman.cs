using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Salesman
    {
        public Salesman()
        {
            Drivers = new HashSet<Driver>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool IsEmployee { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishAddress { get; set; } = null!;
        public string ArabicAddress { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal Percentage { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int PathId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Area Area { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual Pathe Path { get; set; } = null!;
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
