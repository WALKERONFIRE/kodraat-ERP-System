using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPermissionDtl
    {
        public int HdrCode { get; set; }
        public int EmpCode { get; set; }
        public float Period { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual TblEmployee EmpCodeNavigation { get; set; } = null!;
        public virtual HrPermissionHdr HdrCodeNavigation { get; set; } = null!;
    }
}
