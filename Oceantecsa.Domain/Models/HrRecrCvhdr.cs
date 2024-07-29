using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrCvhdr
    {
        public HrRecrCvhdr()
        {
            HrRecrCvdtls = new HashSet<HrRecrCvdtl>();
            HrRecrInterViewDtls = new HashSet<HrRecrInterViewDtl>();
        }

        public int Cvid { get; set; }
        public string FName { get; set; } = null!;
        public string FAddress { get; set; } = null!;
        public string FTelephone { get; set; } = null!;
        public int RecJobId { get; set; }
        public string FMobile { get; set; } = null!;
        public string FEmail { get; set; } = null!;
        public bool Employeed { get; set; }

        public virtual HrRecrJobsHdr RecJob { get; set; } = null!;
        public virtual ICollection<HrRecrCvdtl> HrRecrCvdtls { get; set; }
        public virtual ICollection<HrRecrInterViewDtl> HrRecrInterViewDtls { get; set; }
    }
}
