using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class CustomerGroup
    {
        public CustomerGroup()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public long MainAccountId { get; set; }
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
