using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacType
    {
        public HrVacType()
        {
            HrEmpVacTypes = new HashSet<HrEmpVacType>();
            HrVacAdds = new HashSet<HrVacAdd>();
            HrVacDtls = new HashSet<HrVacDtl>();
        }

        public int Fid { get; set; }
        public string? Fname { get; set; }
        public string? FnameA { get; set; }
        public int DefaultValue { get; set; }
        public bool Canmoved { get; set; }
        public bool Canreplaced { get; set; }
        public bool? SalaryPaid { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<HrEmpVacType> HrEmpVacTypes { get; set; }
        public virtual ICollection<HrVacAdd> HrVacAdds { get; set; }
        public virtual ICollection<HrVacDtl> HrVacDtls { get; set; }
    }
}
