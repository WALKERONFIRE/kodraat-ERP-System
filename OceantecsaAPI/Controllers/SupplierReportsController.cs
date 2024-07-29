using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Shared.DTOs;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SupplierReportsController : ControllerBase
	{
		private readonly ISupplierReportsService _supplierReportsService;

		public SupplierReportsController(ISupplierReportsService supplierReportsService)
		{
			_supplierReportsService = supplierReportsService;
		}
		[HttpGet]
		public async Task<IActionResult> GetSupplierReport(string? cityName)
		{
			var suppliers = await _supplierReportsService.GetSyppliersReport(cityName);
			//if (suppliers == null || suppliers.Count == 0)
			//{
			//	return NotFound();
			//}
			return Ok(suppliers);

		}
		[HttpGet("GetSuppliersPurchase")]
		public async Task<IActionResult> GetSupplierPurchaseInvoices(DateTime? dateFrom, DateTime? dateTo)
		{
			var report = await _supplierReportsService.GetSupplierPurchaseReport(dateFrom, dateTo);
			return Ok(report);
		}
		[HttpGet("filtered-supplier-purchase-report")]
		public async Task<ActionResult<(List<SupplierBalanceReportDTO>, decimal, decimal, decimal)>> GetFilteredSupplierPurchaseReport(string? supplierName, DateTime? dateFrom, DateTime? dateTo)
		{
			var (supplierReports, totalTotalPurchase, totalTotalReturns, totalTotalNetPurchases) = await _supplierReportsService.GetFilteredSupplierBalanceReportAsync(supplierName, dateFrom, dateTo);
			return Ok(new
			{
				SupplierReports = supplierReports,
				TotalTotalPurchase = totalTotalPurchase,
				TotalTotalReturns = totalTotalReturns,
				TotalTotalNetPurchases = totalTotalNetPurchases
			});
		}
		[HttpGet("filtered-supplier-account-statment-report")]
		public async Task<ActionResult> GetSupplierAccountStatementReportAsync(string? supplierName, DateTime? fromDate, DateTime? toDate)
		{
			var report = await _supplierReportsService.GetSupplierAccountStatementReportAsync(supplierName, fromDate, toDate);
			return Ok(report);
		}
	}
}
