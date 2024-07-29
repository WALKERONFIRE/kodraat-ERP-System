using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HryearVacationDtl
    {
        public int HryearVacDtlId { get; set; }
        public int? HryearVacDtlHdrid { get; set; }
        public DateTime? HryearVacDtlFromDate { get; set; }
        public DateTime? HryearVacDtlToDate { get; set; }
        public string? HryearVacDtlDaysNumber { get; set; }
        public string? HryearVacDtlVacName { get; set; }
        public string? HryearVacDtlVacNameA { get; set; }
    }
}
