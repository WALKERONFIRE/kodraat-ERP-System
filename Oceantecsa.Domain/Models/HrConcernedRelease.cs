using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrConcernedRelease
    {
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public int FEmpId { get; set; }
        public bool FRequired { get; set; }
    }
}
