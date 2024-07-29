using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacCancel
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public int VacAddId { get; set; }
        public int VacCount { get; set; }
        public string FDesc { get; set; } = null!;
        public bool FPosted { get; set; }

        public virtual HrVacAdd VacAdd { get; set; } = null!;
    }
}
