using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrInsuranceOffice
    {
        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FnameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string BuildingNo { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Village { get; set; } = null!;
        public string Central { get; set; } = null!;
        public string Govern { get; set; } = null!;
        public DateTime ContractBegin { get; set; }
        public DateTime ContractEnd { get; set; }
    }
}
