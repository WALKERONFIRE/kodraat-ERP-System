using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Locations = new HashSet<Location>();
            UserWarehouses = new HashSet<UserWarehouse>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int WarehouseTypeId { get; set; }
        public int BranchId { get; set; }
        public int CostingTypeId { get; set; }
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Branch Branch { get; set; } = null!;
        public virtual CostingType CostingType { get; set; } = null!;
        public virtual WarehouseType WarehouseType { get; set; } = null!;
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<UserWarehouse> UserWarehouses { get; set; }
    }
}
