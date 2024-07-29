using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEndServiceBonusSpecificHdr
    {
        public HrEndServiceBonusSpecificHdr()
        {
            HrEndServiceBonusSpecificDtls = new HashSet<HrEndServiceBonusSpecificDtl>();
        }

        public int HdrId { get; set; }
        public int PolicyId { get; set; }
        public bool Yearly { get; set; }
        public bool FPosted { get; set; }
        public double FromAcc { get; set; }
        public double ToAcc { get; set; }
        public DateTime FDate { get; set; }

        public virtual ICollection<HrEndServiceBonusSpecificDtl> HrEndServiceBonusSpecificDtls { get; set; }
    }
}
