using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class EarningPeriodDtl
	{
		public int Id { get; set; }
		public DateTime? DateCreated { get; set; }

		public long? SalesInvoiceId { get; set; }
		public string? CustomerEnglishName { get; set; }
		public string? CustomerArabicName { get; set; }
		public string? ProductEnglishName { get; set; }
		public string? ProductArabicName { get; set; }
		public decimal? Quantity { get; set; }
		public decimal? OriginalValue { get; set; }

		public decimal PaidValue { get; set; }
		public decimal Price { get; set; }
		public decimal NetValue { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal Earning { get; set; }






	}
}
