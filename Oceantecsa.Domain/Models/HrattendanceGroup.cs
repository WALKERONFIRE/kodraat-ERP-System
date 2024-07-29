using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrattendanceGroup
    {
        public int FId { get; set; }
        public int MainEmpId { get; set; }
        public int SubEmpId { get; set; }
    }
}
