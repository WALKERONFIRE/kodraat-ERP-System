using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecrItem
    {
        public HrRecrItem()
        {
            HrRecrCvdtls = new HashSet<HrRecrCvdtl>();
            HrRecrInterViewDtls = new HashSet<HrRecrInterViewDtl>();
            HrRecrJobsDtls = new HashSet<HrRecrJobsDtl>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public float FValue { get; set; }

        public virtual ICollection<HrRecrCvdtl> HrRecrCvdtls { get; set; }
        public virtual ICollection<HrRecrInterViewDtl> HrRecrInterViewDtls { get; set; }
        public virtual ICollection<HrRecrJobsDtl> HrRecrJobsDtls { get; set; }
    }
}
