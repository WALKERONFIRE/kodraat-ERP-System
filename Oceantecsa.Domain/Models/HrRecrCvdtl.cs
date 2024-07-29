using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrCvdtl
    {
        public int CvdtlId { get; set; }
        public int FRecItemId { get; set; }
        public string FRecItemName { get; set; } = null!;
        public string FRecItemNameA { get; set; } = null!;
        public int Cvid { get; set; }

        public virtual HrRecrCvhdr Cv { get; set; } = null!;
        public virtual HrRecrItem FRecItem { get; set; } = null!;
    }
}
