using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserWarehouse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WarehouseId { get; set; }
        public bool Bind { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Warehouse Warehouse { get; set; } = null!;
    }
}
