using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class PurchaseReturnDtlDto
	{
		public int Id { get; set; }
		public long PurchaseReturnHdrId { get; set; }
		public long ProductId { get; set; }
		public int UnitId { get; set; }
		public decimal ReturnedQuantity { get; set; }
		public decimal Price { get; set; }
		public bool IsDeleted { get; set; }

		public virtual ICollection<PurchaseInvoiceDtlDto> PurchaseInvoiceDtlDto { get; set; }
	}
}
