using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class ProductUnitPricesDto
	{
	
		public long? ProductId { get; set; }
		public int? MeasurementUnitId { get; set; }
		public decimal? WholesalePrice { get; set; }
		public decimal? HalfWholesalePrice { get; set; }
		public decimal? RetailPrice { get; set; }
	}
}
