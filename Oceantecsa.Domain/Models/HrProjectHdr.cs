using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrProjectHdr
    {
        public HrProjectHdr()
        {
            HrProjectDtls = new HashSet<HrProjectDtl>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrProjectDtl> HrProjectDtls { get; set; }
    }
}
