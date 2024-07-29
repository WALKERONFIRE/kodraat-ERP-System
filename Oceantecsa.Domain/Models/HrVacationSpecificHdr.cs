using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacationSpecificHdr
    {
        public HrVacationSpecificHdr()
        {
            HrVacationSpecificDtls = new HashSet<HrVacationSpecificDtl>();
        }

        public int HdrId { get; set; }
        public int VacTypeId { get; set; }
        /// <summary>
        /// item id,item id,.....
        /// </summary>
        public string SalaryItems { get; set; } = null!;
        public bool Yearly { get; set; }
        public bool FPosted { get; set; }
        public double FromAcc { get; set; }
        public double ToAcc { get; set; }
        public DateTime FDate { get; set; }

        public virtual ICollection<HrVacationSpecificDtl> HrVacationSpecificDtls { get; set; }
    }
}
