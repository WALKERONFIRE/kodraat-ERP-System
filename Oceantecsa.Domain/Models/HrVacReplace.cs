using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacReplace
    {
        public int Fid { get; set; }
        public int EmpId { get; set; }
        public int ReplacedDayes { get; set; }
        public DateTime ReplacedDate { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
    }
}
