using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacHdr
    {
        public HrVacHdr()
        {
            HrVacAdds = new HashSet<HrVacAdd>();
            HrVacDtls = new HashSet<HrVacDtl>();
        }

        public int VacId { get; set; }
        public DateTime FDate1 { get; set; }
        public DateTime FDate2 { get; set; }
        public string FName { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public bool Fpost { get; set; }
        /// <summary>
        /// if deported values done or not
        /// </summary>
        public bool Deported { get; set; }

        public virtual ICollection<HrVacAdd> HrVacAdds { get; set; }
        public virtual ICollection<HrVacDtl> HrVacDtls { get; set; }
    }
}
