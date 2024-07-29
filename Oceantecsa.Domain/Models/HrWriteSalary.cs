using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrWriteSalary
    {
        public string? FDate { get; set; }
        public int? FEmpId { get; set; }
        public float? FSalary { get; set; }
        public float? FPormotion { get; set; }
        public float? FHours { get; set; }
        public float? FMoreHours { get; set; }
        public float? FMoreMoney { get; set; }
        public float? FIns { get; set; }
        public float? FTax { get; set; }
        public int? FAbsence { get; set; }
        public float? FAbsenceDisc { get; set; }
        public float? FBonus { get; set; }
        public float? FDiscount { get; set; }
        public float? FNet { get; set; }
        public bool FDeleted { get; set; }
    }
}
