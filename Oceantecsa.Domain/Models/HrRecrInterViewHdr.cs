using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrInterViewHdr
    {
        public HrRecrInterViewHdr()
        {
            HrRecrInterViewDtls = new HashSet<HrRecrInterViewDtl>();
        }

        public int InterviewHdrId { get; set; }
        public int Stage { get; set; }
        public int RecJobId { get; set; }

        public virtual ICollection<HrRecrInterViewDtl> HrRecrInterViewDtls { get; set; }
    }
}
