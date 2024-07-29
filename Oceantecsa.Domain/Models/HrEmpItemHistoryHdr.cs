using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpItemHistoryHdr
    {
        public HrEmpItemHistoryHdr()
        {
            HrEmpItemHistoryDtls = new HashSet<HrEmpItemHistoryDtl>();
        }

        public int FHdrId { get; set; }
        public DateTime FDate { get; set; }
        public string FDesc { get; set; } = null!;
        public int FItemId { get; set; }
        public bool? IsValue { get; set; }
        public float FValue { get; set; }
        public bool FPost { get; set; }

        public virtual ICollection<HrEmpItemHistoryDtl> HrEmpItemHistoryDtls { get; set; }
    }
}
