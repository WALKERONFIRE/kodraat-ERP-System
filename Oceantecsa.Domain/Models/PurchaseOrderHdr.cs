using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseOrderHdr
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public int OrderId { get; set; }
        public int RequestId { get; set; }
        /// <summary>
        /// Supplier ID
        /// </summary>
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDescription { get; set; } = null!;
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
    }
}
