using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Supplier
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
        public string ChargePersonEnglishName { get; set; } = null!;
        public string ChargePersonArabicName { get; set; } = null!;
        public string ChargePersonJob { get; set; } = null!;
        public string ChargePersonEmail { get; set; } = null!;
        public string ChargePersonMobile { get; set; } = null!;
        public int CityId { get; set; }
        public int SupplierTypeId { get; set; }
        public int SupplierActivityId { get; set; }
        public int SupplierGroupId { get; set; }
        public int ShippingTypeId { get; set; }
        public long AccountId { get; set; }
        public long AccountPayableId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual ShippingType ShippingType { get; set; } = null!;
        public virtual SupplierActivity SupplierActivity { get; set; } = null!;
        public virtual SupplierGroup SupplierGroup { get; set; } = null!;
        public virtual SupplierType SupplierType { get; set; } = null!;
    }
}
