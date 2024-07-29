using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVisaDtl
    {
        public int FId { get; set; }
        public int HdrId { get; set; }
        public int NationalityId { get; set; }
        public int JobId { get; set; }
        public int Fcount { get; set; }
        public string PointOfArrTravel { get; set; } = null!;

        public virtual HrVisa Hdr { get; set; } = null!;
    }
}
