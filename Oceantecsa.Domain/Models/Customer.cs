using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishAddress { get; set; } = null!;
        public string ArabicAddress { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CityId { get; set; }
        public int CustomerTypeId { get; set; }
        public int CustomerActivityId { get; set; }
        public int CustomerGroupId { get; set; }
        public long AccountId { get; set; }
        public long AccountReceivableId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual CustomerActivity CustomerActivity { get; set; } = null!;
        public virtual CustomerGroup CustomerGroup { get; set; } = null!;
        public virtual CustomerType CustomerType { get; set; } = null!;
    }
}
