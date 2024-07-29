using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrOptionDtlPermission
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public float MinPeriod { get; set; }
        public float MaxPeriod { get; set; }
        public int CountInDay { get; set; }
    }
}
