using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseRequestHdr
    {
        public int RequestId { get; set; }
        public int BranchId { get; set; }
        /// <summary>
        /// ID of department that want the Request
        /// </summary>
        public int DepartmentId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestDescription { get; set; } = null!;
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
        public int TypeId { get; set; }

        public virtual PurchaseRequestStatus Status { get; set; } = null!;
        public virtual PurchaseRequestType Type { get; set; } = null!;
    }
}
