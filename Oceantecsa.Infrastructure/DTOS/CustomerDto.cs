using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class CustomerDto
    {
        public string EnglishName { get; set; }  
        public string ArabicName { get; set; }  
        public string EnglishAddress { get; set; }  
        public string ArabicAddress { get; set; }  
        public string Description { get; set; }  
        public string TelephoneNo { get; set; }  
        public string FaxNo { get; set; }  
        public string MobileNo { get; set; }  
        public string Website { get; set; }  
        public string Email { get; set; }  
        public int CityId { get; set; }
        public int CustomerTypeId { get; set; }
        public int CustomerActivityId { get; set; }
        public int CustomerGroupId { get; set; }
        public long AccountId { get; set; }
        public long AccountReceivableId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
