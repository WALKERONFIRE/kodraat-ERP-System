using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVacDtl
    {
        public int EmpId { get; set; }
        public int VacTypeId { get; set; }
        public float VacTypeValue { get; set; }
        public float FUsed { get; set; }
        public float FRemain { get; set; }
        public float DeportedVac { get; set; }
        public int VacId { get; set; }
        /// <summary>
        /// Basic Vac Value coming
        /// </summary>
        public float VacTypeValueOriginal { get; set; }
        public float DeportedVacOriginal { get; set; }

        public virtual TblEmployee Emp { get; set; } = null!;
        public virtual HrVacHdr Vac { get; set; } = null!;
        public virtual HrVacType VacType { get; set; } = null!;
    }
}
