using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class City
    {
        public City()
        {
            Areas = new HashSet<Area>();
            Branches = new HashSet<Branch>();
            Customers = new HashSet<Customer>();
            Drivers = new HashSet<Driver>();
            Salesmen = new HashSet<Salesman>();
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int StateId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual State State { get; set; } = null!;
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Salesman> Salesmen { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
