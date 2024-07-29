using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class FinancialPeriodHdr
    {
        public FinancialPeriodHdr()
        {
            FinancialPeriodDtls = new HashSet<FinancialPeriodDtl>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public string Description { get; set; } = null!;
        public bool Posted { get; set; }
        public bool Locked { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<FinancialPeriodDtl> FinancialPeriodDtls { get; set; }
    }
}
