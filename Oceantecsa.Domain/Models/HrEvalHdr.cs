using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEvalHdr
    {
        public HrEvalHdr()
        {
            HrEvalDtls = new HashSet<HrEvalDtl>();
        }

        public int EvalHdr { get; set; }
        public string EvalName { get; set; } = null!;
        public DateTime FDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Todate { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrEvalDtl> HrEvalDtls { get; set; }
    }
}
