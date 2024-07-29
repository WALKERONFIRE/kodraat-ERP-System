using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryItemHistory
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public int SalaryItem { get; set; }
        public int SalaryId { get; set; }
        public float ItemValue { get; set; }
        public float OldItemValue { get; set; }
    }
}
