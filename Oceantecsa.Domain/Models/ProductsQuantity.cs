using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class ProductsQuantity
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int WarehouseId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int LocationId { get; set; }
    }
}
