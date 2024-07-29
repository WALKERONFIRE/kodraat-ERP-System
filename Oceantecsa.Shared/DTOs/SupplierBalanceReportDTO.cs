using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class SupplierBalanceReportDTO
	{
		public string SupplierName { get; set; }
		public long AccountNumber { get; set; }
		public decimal TotalPurchase { get; set; }
		public decimal TotalReturns { get; set; }
		public decimal NetPurchases { get; set; }
	}
}
