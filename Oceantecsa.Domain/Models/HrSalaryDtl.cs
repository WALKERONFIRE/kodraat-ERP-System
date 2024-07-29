using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryDtl
    {
        public int EmpId { get; set; }
        public int ItemId { get; set; }
        public int SalaryId { get; set; }
        public float FValue { get; set; }
        public float ItemValue { get; set; }
        public short AddLess { get; set; }
        public float Total { get; set; }
        public int TypeId { get; set; }
        public bool? CanInsurance { get; set; }
        public bool? CanTax { get; set; }
        public bool IsSystem { get; set; }
        public float InsuranceVal { get; set; }
        public float InsuranceComp { get; set; }
        public float InsuranceValComp { get; set; }
        public int FDesc { get; set; }
        public float EffectValue { get; set; }
        public bool BeforeCalcTax { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrSalaryItem Item { get; set; } = null!;
        public virtual HrSalaryHdr Salary { get; set; } = null!;
    }
}
