using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrJobsHdr
    {
        public HrRecrJobsHdr()
        {
            HrRecrCvhdrs = new HashSet<HrRecrCvhdr>();
            HrRecrJobsDtls = new HashSet<HrRecrJobsDtl>();
        }

        public int FIdhdr { get; set; }
        public DateTime FDate { get; set; }
        public string FDesc { get; set; } = null!;
        public int JobId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Posted { get; set; }
        public int CandidateCount { get; set; }
        public int State { get; set; }
        public int Stage { get; set; }
        public int ResponseEmp { get; set; }

        public virtual HrJob Job { get; set; } = null!;
        public virtual ICollection<HrRecrCvhdr> HrRecrCvhdrs { get; set; }
        public virtual ICollection<HrRecrJobsDtl> HrRecrJobsDtls { get; set; }
    }
}
