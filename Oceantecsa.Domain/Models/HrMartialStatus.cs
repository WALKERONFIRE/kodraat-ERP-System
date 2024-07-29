using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrMartialStatus
    {
        public HrMartialStatus()
        {
            HrRecJobApplications = new HashSet<HrRecJobApplication>();
        }

        public int MartialStatusId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public string Feild1 { get; set; } = null!;
        public string Feild2 { get; set; } = null!;
        public string Feild3 { get; set; } = null!;

        public virtual ICollection<HrRecJobApplication> HrRecJobApplications { get; set; }
    }
}
