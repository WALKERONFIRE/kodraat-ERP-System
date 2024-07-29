using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Currency
    {
        public Currency()
        {
            BankAccounts = new HashSet<BankAccount>();
            CashBoxes = new HashSet<CashBox>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishDigit { get; set; } = null!;
        public string ArabicDigit { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal CurrencyRate { get; set; }
        public bool MainCurrency { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<CashBox> CashBoxes { get; set; }
    }
}
