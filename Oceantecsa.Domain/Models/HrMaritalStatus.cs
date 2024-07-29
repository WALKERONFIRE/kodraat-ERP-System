using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrMaritalStatus
    {
        public HrMaritalStatus()
        {
            HrRecJobApplications = new HashSet<HrRecJobApplication>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrRecJobApplication> HrRecJobApplications { get; set; }
    }
}
