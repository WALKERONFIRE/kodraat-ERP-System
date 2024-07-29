using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryHdr
    {
        public HrSalaryHdr()
        {
            HrSalaryDtls = new HashSet<HrSalaryDtl>();
            HrSalaryEmpDtls = new HashSet<HrSalaryEmpDtl>();
        }

        public int SalaryId { get; set; }
        public DateTime FDate { get; set; }
        public string FName { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public bool Fpost { get; set; }
        public DateTime Datefrom { get; set; }
        public DateTime Dateto { get; set; }
        public int SalaryType { get; set; }
        public int JournalId { get; set; }

        public virtual ICollection<HrSalaryDtl> HrSalaryDtls { get; set; }
        public virtual ICollection<HrSalaryEmpDtl> HrSalaryEmpDtls { get; set; }
    }
}
