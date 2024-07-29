using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrJob
    {
        public HrJob()
        {
            HrDepartmentSectionJobs = new HashSet<HrDepartmentSectionJob>();
            HrRecrJobsHdrs = new HashSet<HrRecrJobsHdr>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public float TicketCount { get; set; }
        public float TicketDeserverd { get; set; }
        public int DegreeId { get; set; }
        public string FDesc { get; set; } = null!;
        public int EmpCount { get; set; }
        public int FIdhdr { get; set; }
        public string JobTask { get; set; } = null!;
        public string MedicalInuranceDegree { get; set; } = null!;
        public string? SIdlevels { get; set; }
        public float LegationDayValue { get; set; }
        public float TicketVal { get; set; }
        public int InsuranceOffice { get; set; }
        public int InsuranceDegree { get; set; }

        public virtual HrJobDegree Degree { get; set; } = null!;
        public virtual ICollection<HrDepartmentSectionJob> HrDepartmentSectionJobs { get; set; }
        public virtual ICollection<HrRecrJobsHdr> HrRecrJobsHdrs { get; set; }
    }
}
