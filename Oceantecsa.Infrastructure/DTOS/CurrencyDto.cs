using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOs
{
	public class CurrencyDto
	{
		public int Id { get; set; }
		public string EnglishName { get; set; } = null!;
		public string ArabicName { get; set; } = null!;
		public string EnglishDigit { get; set; } = null!;
		public string ArabicDigit { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal CurrencyRate { get; set; }
		public bool MainCurrency { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
	}
}
