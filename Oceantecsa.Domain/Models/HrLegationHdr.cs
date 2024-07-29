using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLegationHdr
    {
        public HrLegationHdr()
        {
            HrLegationDtls = new HashSet<HrLegationDtl>();
        }

        public int FId { get; set; }
        public int EmpId { get; set; }
        public DateTime FDate { get; set; }
        public string Destination { get; set; } = null!;
        /// <summary>
        /// 0 for Inner 1 for Outer
        /// </summary>
        public int FType { get; set; }
        public int CountryId { get; set; }
        public int TownId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FDesc { get; set; } = null!;
        public bool Posted { get; set; }
        public bool Closed { get; set; }
        public DateTime LastDate { get; set; }

        public virtual ICollection<HrLegationDtl> HrLegationDtls { get; set; }
    }
}
