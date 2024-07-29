using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLegationExtensionHdr
    {
        public HrLegationExtensionHdr()
        {
            HrLegationExtensionDtls = new HashSet<HrLegationExtensionDtl>();
        }

        public int HdrId { get; set; }
        public int LegationId { get; set; }
        public DateTime ToDateNew { get; set; }
        /// <summary>
        /// 0 For Decreaese 1 For Increase
        /// </summary>
        public bool? Increase { get; set; }
        public bool Posted { get; set; }

        public virtual ICollection<HrLegationExtensionDtl> HrLegationExtensionDtls { get; set; }
    }
}
