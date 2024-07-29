using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Location
    {
        public Location()
        {
            Divisions = new HashSet<Division>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int WarehouseId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int LocationTypeId { get; set; }

        public virtual LocationType LocationType { get; set; } = null!;
        public virtual Warehouse Warehouse { get; set; } = null!;
        public virtual ICollection<Division> Divisions { get; set; }
    }
}
