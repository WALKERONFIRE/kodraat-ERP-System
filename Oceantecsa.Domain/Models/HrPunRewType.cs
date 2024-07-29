using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPunRewType
    {
        public HrPunRewType()
        {
            HrPunRewDtls = new HashSet<HrPunRewDtl>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        /// <summary>
        /// Default Value
        /// </summary>
        public float DefVal { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string FDesc { get; set; } = null!;
        /// <summary>
        /// 1 or 2 as for Rewards and Punishment
        /// </summary>
        public int TypeId { get; set; }

        public virtual HrPRType Type { get; set; } = null!;
        public virtual ICollection<HrPunRewDtl> HrPunRewDtls { get; set; }
    }
}
