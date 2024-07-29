using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Hrgroup
    {
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public bool? ApplyRules { get; set; }
    }
}
