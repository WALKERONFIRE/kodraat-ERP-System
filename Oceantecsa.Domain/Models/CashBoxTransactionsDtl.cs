using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class CashBoxTransactionsDtl
    {
        public int Id { get; set; }
        public long CashBoxTransactionsId { get; set; }
        public long AccountId { get; set; }
        public long AccountAnalysisId { get; set; }
        public long AccountActivityId { get; set; }
        public long CostCenterId { get; set; }
        public int CurrencyId { get; set; }
        public decimal LocalDebit { get; set; }
        public decimal LocalCredit { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal ForeignDebit { get; set; }
        public decimal ForeignCredit { get; set; }
        public string Description { get; set; } = null!;
        public long CashBoxTransactionsHdrId { get; set; }

        public virtual CashBoxTransactionsHdr CashBoxTransactionsHdr { get; set; } = null!;
    }
}
