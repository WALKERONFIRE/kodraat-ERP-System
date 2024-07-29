using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class InvoiceDTO
	{
		public long Id { get; set; }
		public DateTime InvoiceDate { get; set; }
		public decimal LocalDebit { get; set; }
		public decimal LocalCredit { get; set; }
		public decimal Balance { get; set; }
		public long JournalId { get; set; }
	}
}
