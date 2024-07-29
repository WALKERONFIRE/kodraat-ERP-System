using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrFingerPrintHist
    {
        public int Serial { get; set; }
        public int EmpId { get; set; }
        public DateTime DayVal { get; set; }
        public DateTime TimeVal { get; set; }
        public string StateVal { get; set; } = null!;
        /// <summary>
        /// 0 for Machine or table 1 for Manual
        /// </summary>
        public int FType { get; set; }
    }
}
