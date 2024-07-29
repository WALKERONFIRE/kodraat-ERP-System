using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOs
{
	public class CreateAccountDto
	{
		public long Id { get; set; }
		public long? ParentId { get; set; }
		public string EnglishName { get; set; }
		public string ArabicName { get; set; }
		public string Description { get; set; }
		public DateTime? CreatedDate { get; set; }
		public bool? HaveSub { get; set; }
		public int? AccountLevel { get; set; }
		public int? AccountTypeId { get; set; }
		public int? AccountCloseTypeId { get; set; }
		public int AccountGroupId { get; set; }
		public int CashFlowTypeId { get; set; }
		public int CostExpensesTypeId { get; set; }
		public int FinancialStatmentTypeId { get; set; }
		public int GeneralExpenseTypeId { get; set; }
		public int ManufacturingCostTypeId { get; set; }
		public int DirectCashFlowTypeId { get; set; }
		public int CostCategoryTypeId { get; set; }
		public bool HaveAccountActivity { get; set; }
		public long AccountActivityId { get; set; }
		public bool HaveCostCenter { get; set; }
		public long CostCenterId { get; set; }
		public bool HaveAccountAnalysis { get; set; }
		public int AccountAnalysisTypeId { get; set; }
		public bool IsDeleted { get; set; }
		public bool Active { get; set; }
	}
}
