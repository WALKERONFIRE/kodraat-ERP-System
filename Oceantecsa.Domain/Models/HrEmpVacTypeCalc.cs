using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpVacTypeCalc
    {
        public int FId { get; set; }
        public float FFrom { get; set; }
        public float FTo { get; set; }
        public int VacTypeId { get; set; }
        public float FValue { get; set; }
    }
}
