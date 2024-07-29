using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrOptionHdr
    {
        public HrOptionHdr()
        {
            HrOptionDtlAttendances = new HashSet<HrOptionDtlAttendance>();
        }

        public int HdrId { get; set; }
        public string FName { get; set; } = null!;
        public DateTime FDate { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrOptionDtlAttendance> HrOptionDtlAttendances { get; set; }
    }
}
