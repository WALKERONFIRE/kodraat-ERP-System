using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLoansHdr
    {
        public HrLoansHdr()
        {
            HrLoansDtls = new HashSet<HrLoansDtl>();
        }

        public int LoanId { get; set; }
        public DateTime FDate { get; set; }
        public int TypeId { get; set; }
        public int EmpId { get; set; }
        public decimal LoanVal { get; set; }
        public decimal InstValue { get; set; }
        public int InstCount { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string Guarantor { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public bool Posted { get; set; }
        /// <summary>
        /// 1-Cash         2-Cheaque
        /// </summary>
        public int PayType { get; set; }
        public int BranchId { get; set; }
        public int CashId { get; set; }
        public int BankId { get; set; }
        public string AccountId { get; set; } = null!;
        public int FCurCode { get; set; }
        public bool Dwflinked { get; set; }
        public int Dwfstatus { get; set; }
        public string DwfstatusDescription { get; set; } = null!;
        public bool TopManagement { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrLoanType Type { get; set; } = null!;
        public virtual ICollection<HrLoansDtl> HrLoansDtls { get; set; }
    }
}
