using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPunRewHdr
    {
        public HrPunRewHdr()
        {
            HrPunRewDtls = new HashSet<HrPunRewDtl>();
        }

        public int FId { get; set; }
        public DateTime? FDate { get; set; }
        public string FDesc { get; set; } = null!;
        public int TypeId { get; set; }

        public virtual HrPRType Type { get; set; } = null!;
        public virtual ICollection<HrPunRewDtl> HrPunRewDtls { get; set; }
    }
}
