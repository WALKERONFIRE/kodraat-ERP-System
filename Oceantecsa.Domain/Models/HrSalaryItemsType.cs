using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryItemsType
    {
        public HrSalaryItemsType()
        {
            HrSalaryItems = new HashSet<HrSalaryItem>();
        }

        public short TypeId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public float InsuranceEmp { get; set; }
        public float InsuranceComp { get; set; }

        public virtual ICollection<HrSalaryItem> HrSalaryItems { get; set; }
    }
}
