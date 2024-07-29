using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrProjectHourDistHdr
    {
        public HrProjectHourDistHdr()
        {
            HrProjectHourDistDtls = new HashSet<HrProjectHourDistDtl>();
        }

        public int FHdrId { get; set; }
        public int EmpCode { get; set; }
        public DateTime FDate { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrProjectHourDistDtl> HrProjectHourDistDtls { get; set; }
    }
}
