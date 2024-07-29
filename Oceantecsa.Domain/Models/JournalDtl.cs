using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class JournalDtl
    {
        public JournalDtl()
        {
            CostCenters = new HashSet<CostCenter>();
        }

        public int Id { get; set; }
        public long JournalId { get; set; }
        public long AccountId { get; set; }
        public long AccountAnalysisId { get; set; }
        public long AccountActivityId { get; set; }
        public long CostCenterId { get; set; }
        public decimal LocalDebit { get; set; }
        public decimal LocalCredit { get; set; }
        public decimal ForeignDebit { get; set; }
        public decimal ForeignCredit { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string JournalNotesEn { get; set; } = null!;
        public string JournalNotesAr { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<CostCenter> CostCenters { get; set; }
    }
}
