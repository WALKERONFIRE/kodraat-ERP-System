using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class CustomerGroupDto
    {
        public string EnglishName { get; set; }  
        public string ArabicName { get; set; }  
        public long MainAccountId { get; set; }
        public string Description { get; set; }  
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
