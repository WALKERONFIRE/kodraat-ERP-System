using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrAddLess
    {
        public HrAddLess()
        {
            HrSalaryItems = new HashSet<HrSalaryItem>();
        }

        public short FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;

        public virtual ICollection<HrSalaryItem> HrSalaryItems { get; set; }
    }
}
