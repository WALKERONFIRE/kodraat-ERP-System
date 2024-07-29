using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EarningsPeriodReportsController : ControllerBase
	{
		private readonly IProductPrurchaseEarningReportsService _purchaseEarningReportsService;

		public EarningsPeriodReportsController(IProductPrurchaseEarningReportsService purchaseEarningReportsService)
		{
			_purchaseEarningReportsService = purchaseEarningReportsService;
		}
		[HttpGet]
		public async Task<IActionResult> GetReportAsync(DateTime? dateFrom, DateTime? dateTo)
		{
			var report = await _purchaseEarningReportsService.GetProductEarningReports(dateFrom , dateTo);
			return Ok(report);
		}
	}
}
