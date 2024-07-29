using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class TransactionInHdr
    {
        public TransactionInHdr()
        {
            TransactionInDtls = new HashSet<TransactionInDtl>();
        }

        public long Id { get; set; }
        public long TransactionId { get; set; }
        public int TypeId { get; set; }
        public int InBranchId { get; set; }
        public int InWarehouseId { get; set; }
        public int InLocationId { get; set; }
        public int OutBranchId { get; set; }
        public int OutWarehouseId { get; set; }
        public int OutLocationId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; } = null!;
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

        public virtual ICollection<TransactionInDtl> TransactionInDtls { get; set; }
    }
}
