using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPunishment
    {
        public int Fid { get; set; }
        public DateTime? Fdate { get; set; }
        public int EmpId { get; set; }
        public decimal? Fvalue { get; set; }
        public int ItemId { get; set; }
        public string? Fdesc { get; set; }
        public bool? Fpost { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrSalaryItem Item { get; set; } = null!;
    }
}
