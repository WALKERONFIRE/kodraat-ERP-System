using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrLogInfoHist
    {
        public int Serial { get; set; }
        public int EmpId { get; set; }
        public DateTime DayVal { get; set; }
        public DateTime TimeVal { get; set; }
        public string StateVal { get; set; } = null!;
    }
}
