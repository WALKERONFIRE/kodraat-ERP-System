using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPost
    {
        public int Fid { get; set; }
        public string Fname { get; set; } = null!;
        public string FnameA { get; set; } = null!;
    }
}
