using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrOptionDtlGeneral
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public float HalfDayVacInMonth { get; set; }
        public float AbsentDayVal { get; set; }
        /// <summary>
        /// Sun,Mon,Tues,Wed,Thurs,Frid,Sat
        /// </summary>
        public string AbsentDays { get; set; } = null!;
        public bool CalcInsForAllSalary { get; set; }
    }
}
