using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class SalesCashType
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
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
