using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrEmpDocument
    {
        public int EmpCode { get; set; }
        public int DocCode { get; set; }
        public string ReleasePoint { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public DateTime EndReleaseDate { get; set; }
        public string DocumentNo { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual HrDocument DocCodeNavigation { get; set; } = null!;
        public virtual TblEmployee EmpCodeNavigation { get; set; } = null!;
    }
}
