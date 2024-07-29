using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLoanType
    {
        public HrLoanType()
        {
            HrLoansHdrs = new HashSet<HrLoansHdr>();
        }

        public int TypeId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public bool MustDeduct { get; set; }
        public int SalaryItem { get; set; }
        public string Notes { get; set; } = null!;
        public string Feild1 { get; set; } = null!;
        public string Feild2 { get; set; } = null!;
        public string Feild3 { get; set; } = null!;

        public virtual HrSalaryItem SalaryItemNavigation { get; set; } = null!;
        public virtual ICollection<HrLoansHdr> HrLoansHdrs { get; set; }
    }
}
