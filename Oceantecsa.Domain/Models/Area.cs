using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Area
    {
        public Area()
        {
            Drivers = new HashSet<Driver>();
            Salesmen = new HashSet<Salesman>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CityId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Salesman> Salesmen { get; set; }
    }
}
