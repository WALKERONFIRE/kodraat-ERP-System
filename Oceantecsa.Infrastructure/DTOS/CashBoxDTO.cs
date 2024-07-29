using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class CashBoxDTO
    {
        public string? EnglishName { get; set; }
        public string? ArabicName { get; set; }
        public string? Description { get; set; }
        public int CurrencyId { get; set; }
        public int BranchId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public bool HasMaximumLimit { get; set; }
        public decimal MaximumLimit { get; set; }
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

    }

}
