using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrProjectEmpBind
    {
        public int FId { get; set; }
        public int EmpId { get; set; }
        public int ProjectId { get; set; }
        public int LocationId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
