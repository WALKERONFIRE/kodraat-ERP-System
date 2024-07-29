using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecJobApplication
    {
        public HrRecJobApplication()
        {
            HrRecApplicationQues1s = new HashSet<HrRecApplicationQues1>();
            HrRecApplicationQues2s = new HashSet<HrRecApplicationQues2>();
        }

        public int FId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string ThirdName { get; set; } = null!;
        public string FourthName { get; set; } = null!;
        public DateTime FBirth { get; set; }
        public int? Age { get; set; }
        public string BloodType { get; set; } = null!;
        public string Religion { get; set; } = null!;
        public string Residence { get; set; } = null!;
        public string FAddress { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string Government { get; set; } = null!;
        public string Central { get; set; } = null!;
        public string FTelephone { get; set; } = null!;
        public string FMobileNo { get; set; } = null!;
        public string Qualification { get; set; } = null!;
        public DateTime Graduation { get; set; }
        public string University { get; set; } = null!;
        public int MartialStatusId { get; set; }
        public float MartialYears { get; set; }
        public DateTime MilitryDate { get; set; }
        public string FIdno { get; set; } = null!;
        public DateTime IdDate { get; set; }
        public string IdIssuer { get; set; } = null!;
        public int FStatus { get; set; }
        public float FYearsMarige { get; set; }
        public int ChildCount { get; set; }
        public string FatherJob { get; set; } = null!;
        public string FatherMobile { get; set; } = null!;
        public string RelativeName { get; set; } = null!;
        public string RelativeMobile { get; set; } = null!;
        public bool FGender { get; set; }

        public virtual HrMaritalStatus FStatusNavigation { get; set; } = null!;
        public virtual HrMartialStatus MartialStatus { get; set; } = null!;
        public virtual ICollection<HrRecApplicationQues1> HrRecApplicationQues1s { get; set; }
        public virtual ICollection<HrRecApplicationQues2> HrRecApplicationQues2s { get; set; }
    }
}
