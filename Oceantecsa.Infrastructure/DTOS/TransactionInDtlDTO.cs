using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class TransactionInDtlDTO
    {
        public long TransactionInHdrId { get; set; }
        public long ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
        public string ProductDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}
