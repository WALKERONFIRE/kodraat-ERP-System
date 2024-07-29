using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacAdd
    {
        public HrVacAdd()
        {
            HrVacCancelDtls = new HashSet<HrVacCancelDtl>();
            HrVacCancels = new HashSet<HrVacCancel>();
        }

        public int FId { get; set; }
        public int EmpId { get; set; }
        public int VacTypeId { get; set; }
        public float VacCount { get; set; }
        public DateTime FDate1 { get; set; }
        public DateTime FDate2 { get; set; }
        public string FDesc { get; set; } = null!;
        public float Canceled { get; set; }
        public DateTime? FCancelDate { get; set; }
        public bool FPosted { get; set; }
        public int VacId { get; set; }
        /// <summary>
        /// Net Vac From WeekEnd and Holidays
        /// </summary>
        public float VacNet { get; set; }
        public bool Dwflinked { get; set; }
        public int Dwfstatus { get; set; }
        public int VacRate { get; set; }
        public string DwfstatusDescription { get; set; } = null!;
        public bool TopManagement { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrVacHdr Vac { get; set; } = null!;
        public virtual HrVacType VacType { get; set; } = null!;
        public virtual ICollection<HrVacCancelDtl> HrVacCancelDtls { get; set; }
        public virtual ICollection<HrVacCancel> HrVacCancels { get; set; }
    }
}
