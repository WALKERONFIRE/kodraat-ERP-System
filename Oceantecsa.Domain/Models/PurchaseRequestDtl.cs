using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseRequestDtl
    {
        /// <summary>
        /// id of item of Request
        /// </summary>
        public int RequestId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        /// <summary>
        /// qunatity requiered in request
        /// </summary>
        public decimal Quantity { get; set; }
        public string Description { get; set; } = null!;
        public bool Appoved { get; set; }
        public decimal AppovedQuantity { get; set; }
        public int Id { get; set; }

        public virtual PurchaseRequestHdr Request { get; set; } = null!;
    }
}
