﻿using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrInsuranceDegree
    {
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public int InsuranceOffice { get; set; }
    }
}