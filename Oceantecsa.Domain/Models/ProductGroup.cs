using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public long ParentId { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool HaveSub { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
