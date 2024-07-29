using Oceantecsa.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface ISupplierReportsService
	{
		Task<List<BasicSuppliersDto>> GetSyppliersReport(string? cityName);
		Task<List<SupplierPurchaseInvoiceDTO>> GetSupplierPurchaseReport(DateTime? dateFrom, DateTime? dateTo);
		Task<(List<SupplierBalanceReportDTO>, decimal, decimal, decimal)> GetFilteredSupplierBalanceReportAsync(string supplierName, DateTime? dateFrom, DateTime? dateTo);
		Task<List<SupplierAccountStatementReportDTO>> GetSupplierAccountStatementReportAsync(string? supplierName, DateTime? fromDate, DateTime? toDate);

	}
}
