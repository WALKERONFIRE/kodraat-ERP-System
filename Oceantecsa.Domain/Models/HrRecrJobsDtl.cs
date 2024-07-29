using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrJobsDtl
    {
        public int FIddtl { get; set; }
        public int FRecItemId { get; set; }
        public string FRecItemName { get; set; } = null!;
        public string FRecItemNameA { get; set; } = null!;
        public float Fvalue { get; set; }
        public int FHdrId { get; set; }
        public bool IsSelected { get; set; }
        public int Stage { get; set; }

        public virtual HrRecrJobsHdr FHdr { get; set; } = null!;
        public virtual HrRecrItem FRecItem { get; set; } = null!;
    }
}
