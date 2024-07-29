using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentEmployeeReportsController : ControllerBase
	{
		private readonly IPaymentByEmployeeReportsService _employeeReportsService;

		public PaymentEmployeeReportsController(IPaymentByEmployeeReportsService employeeReportsService)
		{
			_employeeReportsService = employeeReportsService;
		}
		[HttpGet]
		public async Task<IActionResult> GetReportAsync(DateTime? dateFrom, DateTime? dateTo)
		{
			var report =  await _employeeReportsService.GetPaymentReportByEmployeeReports(dateFrom, dateTo);
			return  Ok(report);
		}
	}
}
