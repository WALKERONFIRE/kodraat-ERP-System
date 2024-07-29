using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class SupplierDTO
    {
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
    }
}
