using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class SalesCashTypeDto
    {
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public bool IsBank { get; set; }
        public long BankAccountId { get; set; }
        public long CommissionAccountId { get; set; }
        public long VatAccountId { get; set; }
        public decimal CommissionPercent { get; set; }
        public decimal VatPercent { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
