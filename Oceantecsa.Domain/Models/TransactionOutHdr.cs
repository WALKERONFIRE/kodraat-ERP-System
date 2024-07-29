using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class TransactionOutHdr
    {
        public TransactionOutHdr()
        {
            TransactionOutDtls = new HashSet<TransactionOutDtl>();
        }

        public long Id { get; set; }
        public long TransactionId { get; set; }
        public int TypeId { get; set; }
        public int OutBranchId { get; set; }
        public int OutWarehouseId { get; set; }
        public int InBranchId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; } = null!;
        public long JournalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
        public bool IsReceived { get; set; }
        public bool IsDeleted { get; set; }
        public int OutLocationId { get; set; }

        public virtual ICollection<TransactionOutDtl> TransactionOutDtls { get; set; }
    }
}
