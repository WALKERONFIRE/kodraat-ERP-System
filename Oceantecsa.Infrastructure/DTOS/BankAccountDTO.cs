using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class BankAccountDTO
    {
        public int BankId { get; set; }
        public string BankAccountNo { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CurrencyId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public bool HasMaximumLimit { get; set; }
        public decimal MaximumLimit { get; set; }
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
