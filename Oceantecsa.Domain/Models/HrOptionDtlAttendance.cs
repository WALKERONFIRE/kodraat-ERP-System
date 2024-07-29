using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrOptionDtlAttendance
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public bool RangeIsAllowance { get; set; }
        public bool AllowWorkHour { get; set; }
        public bool CalcPolicyForHalfDay { get; set; }
        public bool DoubleLate { get; set; }

        public virtual HrOptionHdr Hdr { get; set; } = null!;
    }
}
