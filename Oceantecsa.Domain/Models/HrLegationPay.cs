using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLegationPay
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public float FValue { get; set; }
        /// <summary>
        /// 0 for Cash 1 for Salary item
        /// </summary>
        public bool PayType { get; set; }
        public int FBranch { get; set; }
        public int SaftyId { get; set; }
        public int SalaryItemId { get; set; }
    }
}
