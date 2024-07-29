using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSalaryType
    {
        public int FId { get; set; }
        public string Fname { get; set; } = null!;
        public string FnameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public int ItemId { get; set; }
    }
}
