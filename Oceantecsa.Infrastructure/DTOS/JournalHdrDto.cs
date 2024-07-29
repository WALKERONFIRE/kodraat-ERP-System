using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class JournalHdrDto
	{
		public long Id { get; set; }
		public long ManualId { get; set; }
		public string UserManualId { get; set; } = null!;
		public long TransactionId { get; set; }
		public int TransactionTypeId { get; set; }
		public int BranchId { get; set; }
		public int JournalTypeId { get; set; }
		public decimal TotalDebit { get; set; }
		public decimal TotalCredit { get; set; }
		public DateTime CreatedDate { get; set; }
		public int CreatedUser { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ModifiedUser { get; set; }
		public DateTime PostedDate { get; set; }
		public int PostedUser { get; set; }
		public bool Posted { get; set; } // No Edit - No Delete
		public bool Manual { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime TransactionDate { get; set; }
		public long TransactionSerial { get; set; }
		public string JournalNotesEn { get; set; } = null!;
		public string JournalNotesAr { get; set; } = null!;
	}
}
