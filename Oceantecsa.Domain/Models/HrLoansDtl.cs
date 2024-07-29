using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLoansDtl
    {
        public int LoanId { get; set; }
        public int InstCode { get; set; }
        public DateTime InstDate { get; set; }
        public decimal InstVal { get; set; }
        public bool Used { get; set; }
        public decimal Paid { get; set; }
        public decimal? Remain { get; set; }
        public bool Transfered { get; set; }
        public int NewInst { get; set; }
        public int SalaryId { get; set; }
        public int ItemId { get; set; }

        public virtual HrLoansHdr Loan { get; set; } = null!;
    }
}
