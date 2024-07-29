using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrInterViewDtl
    {
        public int InterviewDtlId { get; set; }
        public int Cvid { get; set; }
        public int FRecItemId { get; set; }
        public int InterviewHdrId { get; set; }
        public float FDegree { get; set; }
        public string FNotes { get; set; } = null!;
        public int FUserId { get; set; }

        public virtual HrRecrCvhdr Cv { get; set; } = null!;
        public virtual HrRecrItem FRecItem { get; set; } = null!;
        public virtual HrRecrInterViewHdr InterviewHdr { get; set; } = null!;
    }
}
