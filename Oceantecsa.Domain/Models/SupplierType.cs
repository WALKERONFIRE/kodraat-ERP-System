using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public long MainAccountId { get; set; }
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
