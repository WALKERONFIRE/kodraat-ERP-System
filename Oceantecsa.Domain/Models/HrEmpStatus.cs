using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpStatus
    {
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }
}
