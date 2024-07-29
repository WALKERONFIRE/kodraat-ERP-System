using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndServiceBonusEmp
    {
        public int EmpCode { get; set; }
        public int EndServicePolicy { get; set; }
        public DateTime FDate { get; set; }
        public float FValue { get; set; }
        public bool FPosted { get; set; }

        public virtual TblEmployee EmpCodeNavigation { get; set; } = null!;
    }
}
