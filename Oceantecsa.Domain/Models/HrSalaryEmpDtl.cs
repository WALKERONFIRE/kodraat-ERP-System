using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryEmpDtl
    {
        public int SalaryId { get; set; }
        public int EmpId { get; set; }
        public decimal BasicTotal { get; set; }
        public decimal ChangeTotal { get; set; }
        public decimal DeductionTotal { get; set; }
        public decimal Insurance { get; set; }
        public decimal Taxes { get; set; }
        public decimal BasicInsuranceEmp { get; set; }
        public decimal BasicInsuranceComp { get; set; }
        public decimal ChangeInsuranceEmp { get; set; }
        public decimal ChangeInsuranceComp { get; set; }
        public int BasicInsuranceEmpVal { get; set; }
        public int ChangeInsuranceEmpVal { get; set; }
        /// <summary>
        /// حد الإعفاء الضريبى
        /// </summary>
        public decimal TaxLimitFree { get; set; }
        /// <summary>
        /// الدخل الخاضع للضريبه
        /// </summary>
        public decimal IncomeCalcTax { get; set; }
        /// <summary>
        /// Salary Payment type
        /// </summary>
        public bool CashPay { get; set; }
        /// <summary>
        /// Salary Payment Save
        /// </summary>
        public bool SavePay { get; set; }
        /// <summary>
        /// Salary Payment Post
        /// </summary>
        public bool PostPay { get; set; }
        /// <summary>
        /// Branch or bank depond on CashPay field
        /// </summary>
        public int FirstPayWay { get; set; }
        /// <summary>
        /// safe or acc No depond on CashPay field
        /// </summary>
        public int SecondPayWay { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrSalaryHdr Salary { get; set; } = null!;
    }
}
