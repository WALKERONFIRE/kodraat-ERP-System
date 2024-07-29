using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryItem
    {
        public HrSalaryItem()
        {
            HrEmpItems = new HashSet<HrEmpItem>();
            HrLoanTypes = new HashSet<HrLoanType>();
            HrPdeptItems = new HashSet<HrPdeptItem>();
            HrPunishments = new HashSet<HrPunishment>();
            HrRewards = new HashSet<HrReward>();
            HrSalaryDtls = new HashSet<HrSalaryDtl>();
        }

        public int ItemId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public short AddLess { get; set; }
        public short TypyId { get; set; }
        public decimal DefaultValue { get; set; }
        public int DefaultCount { get; set; }
        public bool? CanInsurance { get; set; }
        public bool? CanTax { get; set; }
        public bool IsSystem { get; set; }
        public float InsuranceVal { get; set; }
        public float InsuranceComp { get; set; }
        public bool Calculated { get; set; }
        public string Equation { get; set; } = null!;
        public bool CanEndService { get; set; }
        public bool BeforeCalcTax { get; set; }

        public virtual HrAddLess AddLessNavigation { get; set; } = null!;
        public virtual HrSalaryItemsType Typy { get; set; } = null!;
        public virtual ICollection<HrEmpItem> HrEmpItems { get; set; }
        public virtual ICollection<HrLoanType> HrLoanTypes { get; set; }
        public virtual ICollection<HrPdeptItem> HrPdeptItems { get; set; }
        public virtual ICollection<HrPunishment> HrPunishments { get; set; }
        public virtual ICollection<HrReward> HrRewards { get; set; }
        public virtual ICollection<HrSalaryDtl> HrSalaryDtls { get; set; }
    }
}
