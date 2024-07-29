using Microsoft.AspNetCore.Http;
using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class ProductDto
	{
		public long Id { get; set; }
		public string EnglishName { get; set; } = null!;
		public string ArabicName { get; set; } = null!;
		public string Description { get; set; } = null!;
		public long ProductGroupId { get; set; }
		public int ProductTypeId { get; set; }
		public int ProductProductionTypeId { get; set; }
		public int MeasurementUnitId { get; set; }
		public int SupplierId { get; set; }
		public string SupplierProductId { get; set; } = null!;
		public int VattypeId { get; set; }
		public decimal Vatpercentage { get; set; }
		public decimal SalesTaxPercent { get; set; }
		public decimal SafetyPoint { get; set; }
		public decimal ReorderPoint { get; set; }
		public bool HasExpiryDate { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
		public int ManufacturingCountryId { get; set; }
		public long AlternativeProduct { get; set; }
		public decimal MaxReorderPoint { get; set; }
		public decimal ProductHeight { get; set; }
		public decimal ProductWidth { get; set; }
		public string Photo { get; set; } = null!;
		//public IFormFile? ImageFile { get; set; }
		public string? Barcode { get; set; }


		public virtual ICollection<ProductUnitPricesDto> ProductUnitPricesDto { get; set; }

	}
}
