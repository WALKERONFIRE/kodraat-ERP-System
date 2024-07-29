using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrVisaReNew
    {
        public int FId { get; set; }
        public int VisaNoId { get; set; }
        public DateTime OldDate { get; set; }
        public DateTime NewDate { get; set; }
    }
}
