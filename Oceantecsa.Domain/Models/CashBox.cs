using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class CashBox
    {
        public CashBox()
        {
            UserCashBoxes = new HashSet<UserCashBox>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CurrencyId { get; set; }
        public int BranchId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public bool HasMaximumLimit { get; set; }
        public decimal MaximumLimit { get; set; }
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Branch Branch { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
        public virtual ICollection<UserCashBox> UserCashBoxes { get; set; }
    }
}
