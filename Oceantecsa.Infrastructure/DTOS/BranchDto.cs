using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class BranchDto
    {
        public string EnglishName { get; set; } 
        public string ArabicName { get; set; } 
        public string EnglishAddress { get; set; }
        public string ArabicAddress { get; set; }
        public string TelephoneNo1 { get; set; }
        public string TelephoneNo2 { get; set; }
        public string TelephoneNo3 { get; set; }
        public string FaxNo { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public bool HeadOffice { get; set; }
        public bool IsFactory { get; set; }
        public bool IsShowRoom { get; set; }
        public long CostCenterId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
