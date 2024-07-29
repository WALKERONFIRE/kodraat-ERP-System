using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class PaymentReportDtl
	{

		public string? EmployeeEnglishName { get; set; } = null!;
		public string? EmployeeArabicName { get; set; } = null!;

		public long? PurchaseInvoiceId { get; set; }
		public DateTime? DateCreated { get; set; }
		public string? CustomerEnglishName { get; set; }
		public string? CustomerArabicName { get; set; }

		public int? PaymentTypeId { get; set; }
		public double Price { get; set; }
	}
}
