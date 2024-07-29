using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPRType
    {
        public HrPRType()
        {
            HrPunRewHdrs = new HashSet<HrPunRewHdr>();
            HrPunRewTypes = new HashSet<HrPunRewType>();
        }

        /// <summary>
        /// انواع المكافآت والجزاءات
        /// </summary>
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrPunRewHdr> HrPunRewHdrs { get; set; }
        public virtual ICollection<HrPunRewType> HrPunRewTypes { get; set; }
    }
}
