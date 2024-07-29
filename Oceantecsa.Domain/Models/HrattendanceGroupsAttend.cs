using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrattendanceGroupsAttend
    {
        public int FId { get; set; }
        public int MainEmpId { get; set; }
        public int SubEmpId { get; set; }
        public DateTime FDate { get; set; }
        public bool Attend { get; set; }
    }
}
