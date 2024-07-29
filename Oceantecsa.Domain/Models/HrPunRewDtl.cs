using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPunRewDtl
    {
        public int FId { get; set; }
        public int? HdrId { get; set; }
        public int? EmpId { get; set; }
        public int? TypeId { get; set; }
        public int? SalaryItemId { get; set; }
        public float? Val { get; set; }

        public virtual HrPunRewHdr? Hdr { get; set; }
        public virtual HrPunRewType? Type { get; set; }
    }
}
