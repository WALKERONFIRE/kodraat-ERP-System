using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            UserBankAccounts = new HashSet<UserBankAccount>();
        }

        public int Id { get; set; }
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

        public virtual Account Account { get; set; } = null!;
        public virtual Bank Bank { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
        public virtual ICollection<UserBankAccount> UserBankAccounts { get; set; }
    }
}
