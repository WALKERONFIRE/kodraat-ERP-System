using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class TransactionInHdrDTO
    {
        public long TransactionId { get; set; }
        public int TypeId { get; set; }
        public int InBranchId { get; set; }
        public int InWarehouseId { get; set; }
        public int InLocationId { get; set; }
        public int OutBranchId { get; set; }
        public int OutWarehouseId { get; set; }
        public int OutLocationId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; } 
        public long TransferId { get; set; }
        public long JournalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
