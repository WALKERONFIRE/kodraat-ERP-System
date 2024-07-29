using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class SalesInvoiceDtlDTO
    {
        public long SalesInvoiceHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public string ProductDescription { get; set; } = null!;
        public decimal ReturnedQuantity { get; set; }
        public decimal Cost { get; set; }
    }
}
