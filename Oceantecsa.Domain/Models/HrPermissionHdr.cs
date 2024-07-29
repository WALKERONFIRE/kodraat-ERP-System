using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrPermissionHdr
    {
        public HrPermissionHdr()
        {
            HrPermissionDtls = new HashSet<HrPermissionDtl>();
        }

        public int FId { get; set; }
        public DateTime FDate { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        /// <summary>
        /// 0 No Policy 1 Delay Policy 2 Permission Policy
        /// </summary>
        public string ApplyPolicy { get; set; } = null!;
        public bool Posted { get; set; }
        /// <summary>
        /// 1 for permissons 2 for missions
        /// </summary>
        public int FType { get; set; }
        public bool Dwflinked { get; set; }
        public int Dwfstatus { get; set; }
        public string DwfstatusDescription { get; set; } = null!;
        public bool TopManagement { get; set; }

        public virtual ICollection<HrPermissionDtl> HrPermissionDtls { get; set; }
    }
}
