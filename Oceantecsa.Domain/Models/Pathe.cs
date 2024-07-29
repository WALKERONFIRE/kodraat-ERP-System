using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Pathe
    {
        public Pathe()
        {
            Drivers = new HashSet<Driver>();
            Salesmen = new HashSet<Salesman>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Salesman> Salesmen { get; set; }
    }
}
