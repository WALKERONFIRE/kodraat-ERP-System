using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrArabyVacYearly
    {
        public DateTime FDate { get; set; }
        public int EmpId { get; set; }
        public int VacTypeId { get; set; }
    }
}
