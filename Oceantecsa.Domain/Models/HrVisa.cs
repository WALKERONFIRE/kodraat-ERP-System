using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVisa
    {
        public HrVisa()
        {
            HrVisaDtls = new HashSet<HrVisaDtl>();
        }

        public int FId { get; set; }
        public string VisaNo { get; set; } = null!;
        public int NationalityId { get; set; }
        public int VisaType { get; set; }
        public DateTime EndDate { get; set; }
        public bool Assigned { get; set; }
        public int EmpId { get; set; }
        public bool FPermanent { get; set; }

        public virtual ICollection<HrVisaDtl> HrVisaDtls { get; set; }
    }
}
