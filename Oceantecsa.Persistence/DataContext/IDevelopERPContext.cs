using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Oceantecsa.Domain.Models;


namespace Oceantecsa.Persistence.DataContext
{
	public partial class IDevelopERPContext : DbContext
	{
		public IDevelopERPContext()
		{
		}

		public IDevelopERPContext(DbContextOptions<IDevelopERPContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Account> Accounts { get; set; } = null!;
		public virtual DbSet<AccountActivity> AccountActivities { get; set; } = null!;
		public virtual DbSet<AccountAnalysisType> AccountAnalysisTypes { get; set; } = null!;
		public virtual DbSet<AccountCloseType> AccountCloseTypes { get; set; } = null!;
		public virtual DbSet<AccountGroup> AccountGroups { get; set; } = null!;
		public virtual DbSet<AccountLevel> AccountLevels { get; set; } = null!;
		public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
		public virtual DbSet<AccountingReportSettingsDtl> AccountingReportSettingsDtls { get; set; } = null!;
		public virtual DbSet<AccountingReportSettingsHdr> AccountingReportSettingsHdrs { get; set; } = null!;
		public virtual DbSet<AccountingSetting> AccountingSettings { get; set; } = null!;
		public virtual DbSet<AccountsPayable> AccountsPayables { get; set; } = null!;
		public virtual DbSet<AccountsReceivable> AccountsReceivables { get; set; } = null!;
		public virtual DbSet<Area> Areas { get; set; } = null!;
		public virtual DbSet<Bank> Banks { get; set; } = null!;
		public virtual DbSet<BankAccount> BankAccounts { get; set; } = null!;
		public virtual DbSet<BankAccountTransaction> BankAccountTransactions { get; set; } = null!;
		public virtual DbSet<Branch> Branches { get; set; } = null!;
		public virtual DbSet<BranchSetting> BranchSettings { get; set; } = null!;
		public virtual DbSet<CashBox> CashBoxes { get; set; } = null!;
		public virtual DbSet<CashBoxTransactionsDtl> CashBoxTransactionsDtls { get; set; } = null!;
		public virtual DbSet<CashBoxTransactionsHdr> CashBoxTransactionsHdrs { get; set; } = null!;
		public virtual DbSet<CashFlowType> CashFlowTypes { get; set; } = null!;
		public virtual DbSet<City> Cities { get; set; } = null!;
		public virtual DbSet<Collector> Collectors { get; set; } = null!;
		public virtual DbSet<Company> Companies { get; set; } = null!;
		public virtual DbSet<CompanyType> CompanyTypes { get; set; } = null!;
		public virtual DbSet<CostCategoryType> CostCategoryTypes { get; set; } = null!;
		public virtual DbSet<CostCenter> CostCenters { get; set; } = null!;
		public virtual DbSet<CostExpensesType> CostExpensesTypes { get; set; } = null!;
		public virtual DbSet<CostingType> CostingTypes { get; set; } = null!;
		public virtual DbSet<Country> Countries { get; set; } = null!;
		public virtual DbSet<Currency> Currencies { get; set; } = null!;
		public virtual DbSet<Customer> Customers { get; set; } = null!;
		public virtual DbSet<CustomerActivity> CustomerActivities { get; set; } = null!;
		public virtual DbSet<CustomerGroup> CustomerGroups { get; set; } = null!;
		public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
		public virtual DbSet<Department> Departments { get; set; } = null!;
		public virtual DbSet<DirectCashFlowType> DirectCashFlowTypes { get; set; } = null!;
		public virtual DbSet<Division> Divisions { get; set; } = null!;
		public virtual DbSet<Driver> Drivers { get; set; } = null!;
		public virtual DbSet<Employee> Employees { get; set; } = null!;
		public virtual DbSet<FinancialPeriodDtl> FinancialPeriodDtls { get; set; } = null!;
		public virtual DbSet<FinancialPeriodHdr> FinancialPeriodHdrs { get; set; } = null!;
		public virtual DbSet<FinancialStatmentType> FinancialStatmentTypes { get; set; } = null!;
		public virtual DbSet<FinancialYear> FinancialYears { get; set; } = null!;
		public virtual DbSet<FinancialYearType> FinancialYearTypes { get; set; } = null!;
		public virtual DbSet<GeneralExpensesType> GeneralExpensesTypes { get; set; } = null!;
		public virtual DbSet<HrAccount> HrAccounts { get; set; } = null!;
		public virtual DbSet<HrAddLess> HrAddLesses { get; set; } = null!;
		public virtual DbSet<HrAdm> HrAdms { get; set; } = null!;
		public virtual DbSet<HrArabyVacYearly> HrArabyVacYearlies { get; set; } = null!;
		public virtual DbSet<HrBoundDegree> HrBoundDegrees { get; set; } = null!;
		public virtual DbSet<HrBreak> HrBreaks { get; set; } = null!;
		public virtual DbSet<HrBreakTime> HrBreakTimes { get; set; } = null!;
		public virtual DbSet<HrConcernedRelease> HrConcernedReleases { get; set; } = null!;
		public virtual DbSet<HrConditonEquation> HrConditonEquations { get; set; } = null!;
		public virtual DbSet<HrDepartment> HrDepartments { get; set; } = null!;
		public virtual DbSet<HrDepartmentSection> HrDepartmentSections { get; set; } = null!;
		public virtual DbSet<HrDepartmentSectionJob> HrDepartmentSectionJobs { get; set; } = null!;
		public virtual DbSet<HrDocument> HrDocuments { get; set; } = null!;
		public virtual DbSet<HrEffect> HrEffects { get; set; } = null!;
		public virtual DbSet<HrEmpCardNoHist> HrEmpCardNoHists { get; set; } = null!;
		public virtual DbSet<HrEmpConcerned> HrEmpConcerneds { get; set; } = null!;
		public virtual DbSet<HrEmpDocument> HrEmpDocuments { get; set; } = null!;
		public virtual DbSet<HrEmpGroupType> HrEmpGroupTypes { get; set; } = null!;
		public virtual DbSet<HrEmpInCall> HrEmpInCalls { get; set; } = null!;
		public virtual DbSet<HrEmpInCallSett> HrEmpInCallSetts { get; set; } = null!;
		public virtual DbSet<HrEmpItem> HrEmpItems { get; set; } = null!;
		public virtual DbSet<HrEmpItemHistoryDtl> HrEmpItemHistoryDtls { get; set; } = null!;
		public virtual DbSet<HrEmpItemHistoryHdr> HrEmpItemHistoryHdrs { get; set; } = null!;
		public virtual DbSet<HrEmpStatus> HrEmpStatuses { get; set; } = null!;
		public virtual DbSet<HrEmpVacType> HrEmpVacTypes { get; set; } = null!;
		public virtual DbSet<HrEmpVacTypeCalc> HrEmpVacTypeCalcs { get; set; } = null!;
		public virtual DbSet<HrEmpWeekEnd> HrEmpWeekEnds { get; set; } = null!;
		public virtual DbSet<HrEndEmp> HrEndEmps { get; set; } = null!;
		public virtual DbSet<HrEndServiceBonusEmp> HrEndServiceBonusEmps { get; set; } = null!;
		public virtual DbSet<HrEndServiceBonusSpecificDtl> HrEndServiceBonusSpecificDtls { get; set; } = null!;
		public virtual DbSet<HrEndServiceBonusSpecificHdr> HrEndServiceBonusSpecificHdrs { get; set; } = null!;
		public virtual DbSet<HrEndServicePolicyDtl> HrEndServicePolicyDtls { get; set; } = null!;
		public virtual DbSet<HrEndServicePolicyHdr> HrEndServicePolicyHdrs { get; set; } = null!;
		public virtual DbSet<HrEvalDeptItem> HrEvalDeptItems { get; set; } = null!;
		public virtual DbSet<HrEvalDtl> HrEvalDtls { get; set; } = null!;
		public virtual DbSet<HrEvalHdr> HrEvalHdrs { get; set; } = null!;
		public virtual DbSet<HrEvalItem> HrEvalItems { get; set; } = null!;
		public virtual DbSet<HrExchangeTicket> HrExchangeTickets { get; set; } = null!;
		public virtual DbSet<HrFingerPrintHist> HrFingerPrintHists { get; set; } = null!;
		public virtual DbSet<HrHoliday> HrHolidays { get; set; } = null!;
		public virtual DbSet<HrIncentiveDtl> HrIncentiveDtls { get; set; } = null!;
		public virtual DbSet<HrIncentiveHdr> HrIncentiveHdrs { get; set; } = null!;
		public virtual DbSet<HrIncentiveSalaryDtl> HrIncentiveSalaryDtls { get; set; } = null!;
		public virtual DbSet<HrIncentiveSalaryHdr> HrIncentiveSalaryHdrs { get; set; } = null!;
		public virtual DbSet<HrInstPayDtl> HrInstPayDtls { get; set; } = null!;
		public virtual DbSet<HrInstPayHdr> HrInstPayHdrs { get; set; } = null!;
		public virtual DbSet<HrInsuranceDegree> HrInsuranceDegrees { get; set; } = null!;
		public virtual DbSet<HrInsuranceOffice> HrInsuranceOffices { get; set; } = null!;
		public virtual DbSet<HrJob> HrJobs { get; set; } = null!;
		public virtual DbSet<HrJobDegree> HrJobDegrees { get; set; } = null!;
		public virtual DbSet<HrLayoffType> HrLayoffTypes { get; set; } = null!;
		public virtual DbSet<HrLegCost> HrLegCosts { get; set; } = null!;
		public virtual DbSet<HrLegationClose> HrLegationCloses { get; set; } = null!;
		public virtual DbSet<HrLegationDtl> HrLegationDtls { get; set; } = null!;
		public virtual DbSet<HrLegationExtensionDtl> HrLegationExtensionDtls { get; set; } = null!;
		public virtual DbSet<HrLegationExtensionHdr> HrLegationExtensionHdrs { get; set; } = null!;
		public virtual DbSet<HrLegationHdr> HrLegationHdrs { get; set; } = null!;
		public virtual DbSet<HrLegationPay> HrLegationPays { get; set; } = null!;
		public virtual DbSet<HrLoanType> HrLoanTypes { get; set; } = null!;
		public virtual DbSet<HrLoansDtl> HrLoansDtls { get; set; } = null!;
		public virtual DbSet<HrLoansHdr> HrLoansHdrs { get; set; } = null!;
		public virtual DbSet<HrLogInfo> HrLogInfos { get; set; } = null!;
		public virtual DbSet<HrLogInfoHist> HrLogInfoHists { get; set; } = null!;
		public virtual DbSet<HrMachineSet> HrMachineSets { get; set; } = null!;
		public virtual DbSet<HrMaritalStatus> HrMaritalStatuses { get; set; } = null!;
		public virtual DbSet<HrMartialStatus> HrMartialStatuses { get; set; } = null!;
		public virtual DbSet<HrMedicalInsuranceType> HrMedicalInsuranceTypes { get; set; } = null!;
		public virtual DbSet<HrNationality> HrNationalities { get; set; } = null!;
		public virtual DbSet<HrNominationType> HrNominationTypes { get; set; } = null!;
		public virtual DbSet<HrOptionDtlAttendance> HrOptionDtlAttendances { get; set; } = null!;
		public virtual DbSet<HrOptionDtlGeneral> HrOptionDtlGenerals { get; set; } = null!;
		public virtual DbSet<HrOptionDtlLeave> HrOptionDtlLeaves { get; set; } = null!;
		public virtual DbSet<HrOptionDtlPermission> HrOptionDtlPermissions { get; set; } = null!;
		public virtual DbSet<HrOptionHdr> HrOptionHdrs { get; set; } = null!;
		public virtual DbSet<HrPRType> HrPRTypes { get; set; } = null!;
		public virtual DbSet<HrPdeptItem> HrPdeptItems { get; set; } = null!;
		public virtual DbSet<HrPdeptItemEmp> HrPdeptItemEmps { get; set; } = null!;
		public virtual DbSet<HrPermissionDtl> HrPermissionDtls { get; set; } = null!;
		public virtual DbSet<HrPermissionHdr> HrPermissionHdrs { get; set; } = null!;
		public virtual DbSet<HrPost> HrPosts { get; set; } = null!;
		public virtual DbSet<HrPperiod> HrPperiods { get; set; } = null!;
		public virtual DbSet<HrPpolicy> HrPpolicies { get; set; } = null!;
		public virtual DbSet<HrProjectDtl> HrProjectDtls { get; set; } = null!;
		public virtual DbSet<HrProjectEmpBind> HrProjectEmpBinds { get; set; } = null!;
		public virtual DbSet<HrProjectHdr> HrProjectHdrs { get; set; } = null!;
		public virtual DbSet<HrProjectHourDistDtl> HrProjectHourDistDtls { get; set; } = null!;
		public virtual DbSet<HrProjectHourDistHdr> HrProjectHourDistHdrs { get; set; } = null!;
		public virtual DbSet<HrPtime> HrPtimes { get; set; } = null!;
		public virtual DbSet<HrPtimesPeriod> HrPtimesPeriods { get; set; } = null!;
		public virtual DbSet<HrPunRewDtl> HrPunRewDtls { get; set; } = null!;
		public virtual DbSet<HrPunRewHdr> HrPunRewHdrs { get; set; } = null!;
		public virtual DbSet<HrPunRewType> HrPunRewTypes { get; set; } = null!;
		public virtual DbSet<HrPunishment> HrPunishments { get; set; } = null!;
		public virtual DbSet<HrRecApplicationQues1> HrRecApplicationQues1s { get; set; } = null!;
		public virtual DbSet<HrRecApplicationQues2> HrRecApplicationQues2s { get; set; } = null!;
		public virtual DbSet<HrRecApplicationQuestion> HrRecApplicationQuestions { get; set; } = null!;
		public virtual DbSet<HrRecJobApplication> HrRecJobApplications { get; set; } = null!;
		public virtual DbSet<HrRecrCvdtl> HrRecrCvdtls { get; set; } = null!;
		public virtual DbSet<HrRecrCvhdr> HrRecrCvhdrs { get; set; } = null!;
		public virtual DbSet<HrRecrInterViewDtl> HrRecrInterViewDtls { get; set; } = null!;
		public virtual DbSet<HrRecrInterViewHdr> HrRecrInterViewHdrs { get; set; } = null!;
		public virtual DbSet<HrRecrItem> HrRecrItems { get; set; } = null!;
		public virtual DbSet<HrRecrJobsDtl> HrRecrJobsDtls { get; set; } = null!;
		public virtual DbSet<HrRecrJobsHdr> HrRecrJobsHdrs { get; set; } = null!;
		public virtual DbSet<HrRecrState> HrRecrStates { get; set; } = null!;
		public virtual DbSet<HrRelationType> HrRelationTypes { get; set; } = null!;
		public virtual DbSet<HrReward> HrRewards { get; set; } = null!;
		public virtual DbSet<HrSalaryBound> HrSalaryBounds { get; set; } = null!;
		public virtual DbSet<HrSalaryDtl> HrSalaryDtls { get; set; } = null!;
		public virtual DbSet<HrSalaryEmpDtl> HrSalaryEmpDtls { get; set; } = null!;
		public virtual DbSet<HrSalaryHdr> HrSalaryHdrs { get; set; } = null!;
		public virtual DbSet<HrSalaryInsHistory> HrSalaryInsHistories { get; set; } = null!;
		public virtual DbSet<HrSalaryItem> HrSalaryItems { get; set; } = null!;
		public virtual DbSet<HrSalaryItemHistory> HrSalaryItemHistories { get; set; } = null!;
		public virtual DbSet<HrSalaryItemsGroup> HrSalaryItemsGroups { get; set; } = null!;
		public virtual DbSet<HrSalaryItemsType> HrSalaryItemsTypes { get; set; } = null!;
		public virtual DbSet<HrSalaryType> HrSalaryTypes { get; set; } = null!;
		public virtual DbSet<HrSalaryWithCurrency> HrSalaryWithCurrencies { get; set; } = null!;
		public virtual DbSet<HrSetting> HrSettings { get; set; } = null!;
		public virtual DbSet<HrStopStartEmp> HrStopStartEmps { get; set; } = null!;
		public virtual DbSet<HrStopStartType> HrStopStartTypes { get; set; } = null!;
		public virtual DbSet<HrTaxConst> HrTaxConsts { get; set; } = null!;
		public virtual DbSet<HrTrainDtl> HrTrainDtls { get; set; } = null!;
		public virtual DbSet<HrTrainHdr> HrTrainHdrs { get; set; } = null!;
		public virtual DbSet<HrVacAdd> HrVacAdds { get; set; } = null!;
		public virtual DbSet<HrVacAdm> HrVacAdms { get; set; } = null!;
		public virtual DbSet<HrVacCancel> HrVacCancels { get; set; } = null!;
		public virtual DbSet<HrVacCancelDtl> HrVacCancelDtls { get; set; } = null!;
		public virtual DbSet<HrVacDtl> HrVacDtls { get; set; } = null!;
		public virtual DbSet<HrVacHdr> HrVacHdrs { get; set; } = null!;
		public virtual DbSet<HrVacReplace> HrVacReplaces { get; set; } = null!;
		public virtual DbSet<HrVacType> HrVacTypes { get; set; } = null!;
		public virtual DbSet<HrVacationSpecificDtl> HrVacationSpecificDtls { get; set; } = null!;
		public virtual DbSet<HrVacationSpecificHdr> HrVacationSpecificHdrs { get; set; } = null!;
		public virtual DbSet<HrVisa> HrVisas { get; set; } = null!;
		public virtual DbSet<HrVisaDtl> HrVisaDtls { get; set; } = null!;
		public virtual DbSet<HrVisaReNew> HrVisaReNews { get; set; } = null!;
		public virtual DbSet<HrVisaType> HrVisaTypes { get; set; } = null!;
		public virtual DbSet<HrWeekEnd> HrWeekEnds { get; set; } = null!;
		public virtual DbSet<HrWriteSalary> HrWriteSalaries { get; set; } = null!;
		public virtual DbSet<HrYearHoliday> HrYearHolidays { get; set; } = null!;
		public virtual DbSet<HrattendanceGroup> HrattendanceGroups { get; set; } = null!;
		public virtual DbSet<HrattendanceGroupsAttend> HrattendanceGroupsAttends { get; set; } = null!;
		public virtual DbSet<HrattendancePlanDtl> HrattendancePlanDtls { get; set; } = null!;
		public virtual DbSet<HrattendancePlanEmp> HrattendancePlanEmps { get; set; } = null!;
		public virtual DbSet<HrattendancePlanHdr> HrattendancePlanHdrs { get; set; } = null!;
		public virtual DbSet<HrdayVacation> HrdayVacations { get; set; } = null!;
		public virtual DbSet<HrdaysName> HrdaysNames { get; set; } = null!;
		public virtual DbSet<HrempGroup> HrempGroups { get; set; } = null!;
		public virtual DbSet<HrempGroupHist> HrempGroupHists { get; set; } = null!;
		public virtual DbSet<Hrgroup> Hrgroups { get; set; } = null!;
		public virtual DbSet<HryearVacationDtl> HryearVacationDtls { get; set; } = null!;
		public virtual DbSet<HryearVacationHdr> HryearVacationHdrs { get; set; } = null!;
		public virtual DbSet<JournalDtl> JournalDtls { get; set; } = null!;
		public virtual DbSet<JournalHdr> JournalHdrs { get; set; } = null!;
		public virtual DbSet<JournalTransactionType> JournalTransactionTypes { get; set; } = null!;
		public virtual DbSet<JournalType> JournalTypes { get; set; } = null!;
		public virtual DbSet<Location> Locations { get; set; } = null!;
		public virtual DbSet<LocationType> LocationTypes { get; set; } = null!;
		public virtual DbSet<ManufacturingCostType> ManufacturingCostTypes { get; set; } = null!;
		public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; } = null!;
		public virtual DbSet<Menu> Menus { get; set; } = null!;
		public virtual DbSet<ModuleAccountsDtl> ModuleAccountsDtls { get; set; } = null!;
		public virtual DbSet<ModuleAccountsHdr> ModuleAccountsHdrs { get; set; } = null!;
		public virtual DbSet<OfferReason> OfferReasons { get; set; } = null!;
		public virtual DbSet<OfferType> OfferTypes { get; set; } = null!;
		public virtual DbSet<Pathe> Pathes { get; set; } = null!;
		public virtual DbSet<PaymentType> PaymentTypes { get; set; } = null!;
		public virtual DbSet<Product> Products { get; set; } = null!;
		public virtual DbSet<ProductGroup> ProductGroups { get; set; } = null!;
		public virtual DbSet<ProductProductionType> ProductProductionTypes { get; set; } = null!;
		public virtual DbSet<ProductProperty> ProductProperties { get; set; } = null!;
		public virtual DbSet<ProductSetting> ProductSettings { get; set; } = null!;
		public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
		public virtual DbSet<ProductUnitPrice> ProductUnitPrices { get; set; } = null!;
		public virtual DbSet<ProductsCost> ProductsCosts { get; set; } = null!;
		public virtual DbSet<ProductsPurchasePrice> ProductsPurchasePrices { get; set; } = null!;
		public virtual DbSet<ProductsQuantity> ProductsQuantities { get; set; } = null!;
		public virtual DbSet<PurchaseInvoiceDtl> PurchaseInvoiceDtls { get; set; } = null!;
		public virtual DbSet<PurchaseInvoiceHdr> PurchaseInvoiceHdrs { get; set; } = null!;
		public virtual DbSet<PurchaseOrderDtl> PurchaseOrderDtls { get; set; } = null!;
		public virtual DbSet<PurchaseOrderHdr> PurchaseOrderHdrs { get; set; } = null!;
		public virtual DbSet<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; } = null!;
		public virtual DbSet<PurchaseRequestDtl> PurchaseRequestDtls { get; set; } = null!;
		public virtual DbSet<PurchaseRequestHdr> PurchaseRequestHdrs { get; set; } = null!;
		public virtual DbSet<PurchaseRequestStatus> PurchaseRequestStatuses { get; set; } = null!;
		public virtual DbSet<PurchaseRequestType> PurchaseRequestTypes { get; set; } = null!;
		public virtual DbSet<PurchaseReturnDtl> PurchaseReturnDtls { get; set; } = null!;
		public virtual DbSet<PurchaseReturnHdr> PurchaseReturnHdrs { get; set; } = null!;
		public virtual DbSet<ReceiptType> ReceiptTypes { get; set; } = null!;
		public virtual DbSet<SalesCashType> SalesCashTypes { get; set; } = null!;
		public virtual DbSet<SalesInvoiceDtl> SalesInvoiceDtls { get; set; } = null!;
		public virtual DbSet<SalesInvoiceHdr> SalesInvoiceHdrs { get; set; } = null!;
		public virtual DbSet<SalesReturnReason> SalesReturnReasons { get; set; } = null!;
		public virtual DbSet<Salesman> Salesmen { get; set; } = null!;
		public virtual DbSet<Section> Sections { get; set; } = null!;
		public virtual DbSet<Shelf> Shelves { get; set; } = null!;
		public virtual DbSet<ShippingType> ShippingTypes { get; set; } = null!;
		public virtual DbSet<State> States { get; set; } = null!;
		public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
		public virtual DbSet<SupplierActivity> SupplierActivities { get; set; } = null!;
		public virtual DbSet<SupplierGroup> SupplierGroups { get; set; } = null!;
		public virtual DbSet<SupplierType> SupplierTypes { get; set; } = null!;
		public virtual DbSet<SystemTranslation> SystemTranslations { get; set; } = null!;
		public virtual DbSet<TblEmployee> TblEmployees { get; set; } = null!;
		public virtual DbSet<TransactionInDtl> TransactionInDtls { get; set; } = null!;
		public virtual DbSet<TransactionInHdr> TransactionInHdrs { get; set; } = null!;
		public virtual DbSet<TransactionInType> TransactionInTypes { get; set; } = null!;
		public virtual DbSet<TransactionOutDtl> TransactionOutDtls { get; set; } = null!;
		public virtual DbSet<TransactionOutHdr> TransactionOutHdrs { get; set; } = null!;
		public virtual DbSet<TransactionOutType> TransactionOutTypes { get; set; } = null!;
		public virtual DbSet<User> Users { get; set; } = null!;
		public virtual DbSet<UserBankAccount> UserBankAccounts { get; set; } = null!;
		public virtual DbSet<UserBranch> UserBranches { get; set; } = null!;
		public virtual DbSet<UserCashBox> UserCashBoxes { get; set; } = null!;
		public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
		public virtual DbSet<UserGroupPermission> UserGroupPermissions { get; set; } = null!;
		public virtual DbSet<UserPrivilege> UserPrivileges { get; set; } = null!;
		public virtual DbSet<UserWarehouse> UserWarehouses { get; set; } = null!;
		public virtual DbSet<Vattype> Vattypes { get; set; } = null!;
		public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
		public virtual DbSet<WarehouseType> WarehouseTypes { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
				optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IDevelopERP;Trusted_Connection=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.AccountActivityId).HasColumnName("AccountActivityID");

				entity.Property(e => e.AccountAnalysisTypeId).HasColumnName("AccountAnalysisTypeID");

				entity.Property(e => e.AccountCloseTypeId)
					.HasColumnName("AccountCloseTypeID")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

				entity.Property(e => e.AccountLevel).HasDefaultValueSql("((0))");

				entity.Property(e => e.AccountTypeId)
					.HasColumnName("AccountTypeID")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ArabicName).HasMaxLength(250);

				entity.Property(e => e.CashFlowTypeId).HasColumnName("CashFlowTypeID");

				entity.Property(e => e.CostCategoryTypeId).HasColumnName("CostCategoryTypeID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.CostExpensesTypeId).HasColumnName("CostExpensesTypeID");

				entity.Property(e => e.CreatedDate).HasColumnType("datetime");

				entity.Property(e => e.Description).HasMaxLength(500);

				entity.Property(e => e.DirectCashFlowTypeId).HasColumnName("DirectCashFlowTypeID");

				entity.Property(e => e.EnglishName).HasMaxLength(250);

				entity.Property(e => e.FinancialStatmentTypeId).HasColumnName("FinancialStatmentTypeID");

				entity.Property(e => e.GeneralExpenseTypeId).HasColumnName("GeneralExpenseTypeID");

				entity.Property(e => e.ManufacturingCostTypeId).HasColumnName("ManufacturingCostTypeID");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<AccountActivity>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<AccountAnalysisType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountCloseType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountGroup>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountLevel>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountingReportSettingsDtl>(entity =>
			{
				entity.HasKey(e => new { e.Id, e.AccountingReportSettingsHdrId });

				entity.ToTable("AccountingReportSettingsDtl");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountingReportSettingsHdrId).HasColumnName("AccountingReportSettingsHdrID");

				entity.Property(e => e.AccountArabicNames).HasDefaultValueSql("('')");

				entity.Property(e => e.AccountEnglishNames).HasDefaultValueSql("('')");

				entity.Property(e => e.AccountIds)
					.HasColumnName("AccountIDs")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountingReportSettingsHdr>(entity =>
			{
				entity.ToTable("AccountingReportSettingsHdr");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<AccountingSetting>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.MainCashBoxAccountId).HasColumnName("MainCashBoxAccountID");

				entity.Property(e => e.MainWarehouseAccountId).HasColumnName("MainWarehouseAccountID");
			});

			modelBuilder.Entity<AccountsPayable>(entity =>
			{
				entity.ToTable("AccountsPayable");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.Aplevel).HasColumnName("APLevel");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<AccountsReceivable>(entity =>
			{
				entity.ToTable("AccountsReceivable");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Arlevel).HasColumnName("ARLevel");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<Area>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Areas)
					.HasForeignKey(d => d.CityId)
					.HasConstraintName("FK_Areas_Cities");
			});

			modelBuilder.Entity<Bank>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<BankAccount>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.BankAccountNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BankId).HasColumnName("BankID");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrentBalance).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MaximumLimit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.OpeningBalance).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.BankAccounts)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BankAccounts_Accounts");

				entity.HasOne(d => d.Bank)
					.WithMany(p => p.BankAccounts)
					.HasForeignKey(d => d.BankId)
					.HasConstraintName("FK_BankAccounts_Banks");

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.BankAccounts)
					.HasForeignKey(d => d.CurrencyId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BankAccounts_Currencies");
			});

			modelBuilder.Entity<BankAccountTransaction>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

				entity.Property(e => e.BankAccountTransactionId).HasColumnName("BankAccountTransactionID");

				entity.Property(e => e.BankId).HasColumnName("BankID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CreditAccountId).HasColumnName("CreditAccountID");

				entity.Property(e => e.CreditCostCenterId).HasColumnName("CreditCostCenterID");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrencyRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

				entity.Property(e => e.DebitAccountId).HasColumnName("DebitAccountID");

				entity.Property(e => e.DebitCostCenterId).HasColumnName("DebitCostCenterID");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ForeignValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.LocalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

				entity.Property(e => e.PurchaseInvoiceId).HasColumnName("PurchaseInvoiceID");

				entity.Property(e => e.ReceiptTypeId).HasColumnName("ReceiptTypeID");

				entity.Property(e => e.SalesInvoiceId).HasColumnName("SalesInvoiceID");

				entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

				entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

				entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
			});

			modelBuilder.Entity<Branch>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FaxNo)
					.HasMaxLength(10)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TelephoneNo1)
					.HasMaxLength(10)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TelephoneNo2)
					.HasMaxLength(10)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TelephoneNo3)
					.HasMaxLength(10)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Branches)
					.HasForeignKey(d => d.CityId)
					.HasConstraintName("FK_Branches_Cities");
			});

			modelBuilder.Entity<BranchSetting>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CashBoxAccountId).HasColumnName("CashBoxAccountID");

				entity.Property(e => e.CashBoxId).HasColumnName("CashBoxID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");
			});

			modelBuilder.Entity<CashBox>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrentBalance).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MaximumLimit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.OpeningBalance).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.CashBoxes)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CashBoxes_Accounts");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.CashBoxes)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CashBoxes_Branches");

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.CashBoxes)
					.HasForeignKey(d => d.CurrencyId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CashBoxes_Currencies");
			});

			modelBuilder.Entity<CashBoxTransactionsDtl>(entity =>
			{
				entity.HasKey(e => new { e.Id, e.CashBoxTransactionsId });

				entity.ToTable("CashBoxTransactionsDtl");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.CashBoxTransactionsId).HasColumnName("CashBoxTransactionsID");

				entity.Property(e => e.AccountActivityId).HasColumnName("AccountActivityID");

				entity.Property(e => e.AccountAnalysisId).HasColumnName("AccountAnalysisID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrencyRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ForeignCredit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ForeignDebit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.LocalCredit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.LocalDebit).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.CashBoxTransactionsHdr)
					.WithMany(p => p.CashBoxTransactionsDtls)
					.HasForeignKey(d => d.CashBoxTransactionsHdrId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("CashBoxTransactionsHdrId");
			});

			modelBuilder.Entity<CashBoxTransactionsHdr>(entity =>
			{
				entity.ToTable("CashBoxTransactionsHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CashBoxId).HasColumnName("CashBoxID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrencyRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ForeignValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.LocalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PurchaseInvoiceId).HasColumnName("PurchaseInvoiceID");

				entity.Property(e => e.ReceiptTypeId).HasColumnName("ReceiptTypeID");

				entity.Property(e => e.SalesInvoiceId).HasColumnName("SalesInvoiceID");

				entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

				entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

				entity.Property(e => e.TransactionDate).HasColumnType("datetime");

				entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
			});

			modelBuilder.Entity<CashFlowType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<City>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.StateId).HasColumnName("StateID");

				entity.HasOne(d => d.State)
					.WithMany(p => p.Cities)
					.HasForeignKey(d => d.StateId)
					.HasConstraintName("FK_Cities_States");
			});

			modelBuilder.Entity<Collector>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AreaId).HasColumnName("AreaID");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MobileNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Company>(entity =>
			{
				entity.ToTable("Company");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.Active)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Blue).HasDefaultValueSql("((255))");

				entity.Property(e => e.Capital).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.CardExportNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CardImportNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CommercialRegisterNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

				entity.Property(e => e.CountryId).HasColumnName("CountryID");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EstablishmentDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FacebookPage)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FaxNo)
					.HasMaxLength(10)
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.GeneralTaxNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Green).HasDefaultValueSql("((255))");

				entity.Property(e => e.InstagramAccount)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LargeLogo).HasColumnType("image");

				entity.Property(e => e.Red).HasDefaultValueSql("((255))");

				entity.Property(e => e.SalesTaxNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Shareholders)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SmallLogo).HasColumnType("image");

				entity.Property(e => e.SnapChatAccount)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TelephoneNo1)
					.HasMaxLength(10)
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.TelephoneNo2)
					.HasMaxLength(10)
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.TelephoneNo3)
					.HasMaxLength(10)
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.TwitterAccount)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.UniqueNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ValueAddedTaxNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.WebSite)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.YoutubeChannel)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<CompanyType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<CostCategoryType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<CostCenter>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<CostExpensesType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<CostingType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Country>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Currency>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicDigit)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CurrencyRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishDigit)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.AccountReceivableId).HasColumnName("AccountReceivableID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.CustomerActivityId).HasColumnName("CustomerActivityID");

				entity.Property(e => e.CustomerGroupId).HasColumnName("CustomerGroupID");

				entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FaxNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MobileNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TelephoneNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Website)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Customers_Accounts");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.CityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Customers_Cities");

				entity.HasOne(d => d.CustomerActivity)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.CustomerActivityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Customers_CustomerActivities");

				entity.HasOne(d => d.CustomerGroup)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.CustomerGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Customers_CustomerGroups");

				entity.HasOne(d => d.CustomerType)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.CustomerTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Customers_CustomerTypes");
			});

			modelBuilder.Entity<CustomerActivity>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<CustomerGroup>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainAccountId).HasColumnName("MainAccountID");
			});

			modelBuilder.Entity<CustomerType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainAccountId).HasColumnName("MainAccountID");
			});

			modelBuilder.Entity<Department>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<DirectCashFlowType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Division>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.HasOne(d => d.Location)
					.WithMany(p => p.Divisions)
					.HasForeignKey(d => d.LocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Divisions_Locations");
			});

			modelBuilder.Entity<Driver>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AreaId).HasColumnName("AreaID");

				entity.Property(e => e.CarNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MobileNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PathId).HasColumnName("PathID");

				entity.Property(e => e.SalesmanId).HasColumnName("SalesmanID");

				entity.HasOne(d => d.Area)
					.WithMany(p => p.Drivers)
					.HasForeignKey(d => d.AreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Drivers_Areas");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Drivers)
					.HasForeignKey(d => d.CityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Drivers_Cities");

				entity.HasOne(d => d.Employee)
					.WithMany(p => p.Drivers)
					.HasForeignKey(d => d.EmployeeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Drivers_Employees");

				entity.HasOne(d => d.Path)
					.WithMany(p => p.Drivers)
					.HasForeignKey(d => d.PathId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Drivers_Pathes");

				entity.HasOne(d => d.Salesman)
					.WithMany(p => p.Drivers)
					.HasForeignKey(d => d.SalesmanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Drivers_Salesmen");
			});

			modelBuilder.Entity<Employee>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName).HasMaxLength(100);

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.EnglishName).HasMaxLength(100);

				entity.Property(e => e.SectionId).HasColumnName("SectionID");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Employees)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Employees_Branches");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.Employees)
					.HasForeignKey(d => d.DepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Employees_Departments");

				entity.HasOne(d => d.Section)
					.WithMany(p => p.Employees)
					.HasForeignKey(d => d.SectionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Employees_Sections");
			});

			modelBuilder.Entity<FinancialPeriodDtl>(entity =>
			{
				entity.ToTable("FinancialPeriodDtl");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.MonthFrom)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.MonthTo)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

				entity.HasOne(d => d.Period)
					.WithMany(p => p.FinancialPeriodDtls)
					.HasForeignKey(d => d.PeriodId)
					.HasConstraintName("FK_FinancialPeriodDtl_FinancialPeriodHdr");
			});

			modelBuilder.Entity<FinancialPeriodHdr>(entity =>
			{
				entity.ToTable("FinancialPeriodHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PeriodEnd)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PeriodStart)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<FinancialStatmentType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<FinancialYear>(entity =>
			{
				entity.ToTable("FinancialYear");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<FinancialYearType>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<GeneralExpensesType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrAccount>(entity =>
			{
				entity.HasNoKey();

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.FId).HasColumnName("fID");
			});

			modelBuilder.Entity<HrAddLess>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrAddLess");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrAdm>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrAdm");

				entity.Property(e => e.ArriveTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 8:00:00 AM')");

				entity.Property(e => e.DelayTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 8:00:00 AM')");

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.Fid)
					.ValueGeneratedOnAdd()
					.HasColumnName("fid");

				entity.Property(e => e.LeaveTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 5:00:00 PM')");

				entity.Property(e => e.OverTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 5:00:00 PM')");

				entity.HasOne(d => d.Department)
					.WithMany()
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_HrAdm_HrDepartment");
			});

			modelBuilder.Entity<HrArabyVacYearly>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrArabyVacYearly");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.VacTypeId).HasColumnName("VacTypeID");
			});

			modelBuilder.Entity<HrBoundDegree>(entity =>
			{
				entity.HasKey(e => new { e.DegreeId, e.BoundCode });

				entity.ToTable("HrBoundDegree");

				entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.BoundCodeNavigation)
					.WithMany(p => p.HrBoundDegrees)
					.HasForeignKey(d => d.BoundCode)
					.HasConstraintName("FK_HrBoundDegree_HrSalaryBounds");

				entity.HasOne(d => d.Degree)
					.WithMany(p => p.HrBoundDegrees)
					.HasForeignKey(d => d.DegreeId)
					.HasConstraintName("FK_HrBoundDegree_HrJobDegrees");
			});

			modelBuilder.Entity<HrBreak>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrBreakTime>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.BreakId).HasColumnName("BreakID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate");

				entity.Property(e => e.FromTime).HasColumnType("datetime");

				entity.Property(e => e.GroupId).HasColumnName("GroupID");

				entity.Property(e => e.ToTime).HasColumnType("datetime");
			});

			modelBuilder.Entity<HrConcernedRelease>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrConcernedRelease");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FEmpId).HasColumnName("fEmpID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FRequired).HasColumnName("fRequired");
			});

			modelBuilder.Entity<HrConditonEquation>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrConditonEquation");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.IfConditionName)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IfConditionName1)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IfConditionNameA)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IfConditionNameA1)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IfConditionVal)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IfConditionVal1)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Operator)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SalaryItemId).HasColumnName("SalaryItemID");

				entity.Property(e => e.ThenName)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ThenNameA)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ThenVal)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrDepartment>(entity =>
			{
				entity.HasKey(e => e.DepartmentId);

				entity.ToTable("HrDepartment");

				entity.Property(e => e.DepartmentId)
					.ValueGeneratedNever()
					.HasColumnName("DepartmentID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CompId).HasColumnName("CompID");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrDepartmentSection>(entity =>
			{
				entity.HasKey(e => e.SectionId);

				entity.Property(e => e.SectionId)
					.ValueGeneratedNever()
					.HasColumnName("SectionID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(215)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNamea)
					.HasMaxLength(50)
					.HasColumnName("fNamea")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.HrDepartmentSections)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_HrDepartmentSections_HrDepartment");
			});

			modelBuilder.Entity<HrDepartmentSectionJob>(entity =>
			{
				entity.HasKey(e => new { e.SectionId, e.JobId })
					.HasName("PK_HrDepartmentsectionJob");

				entity.ToTable("HrDepartmentSectionJob");

				entity.Property(e => e.SectionId).HasColumnName("SectionID");

				entity.HasOne(d => d.Job)
					.WithMany(p => p.HrDepartmentSectionJobs)
					.HasForeignKey(d => d.JobId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrDepartmentSectionJob_HrJobs");

				entity.HasOne(d => d.Section)
					.WithMany(p => p.HrDepartmentSectionJobs)
					.HasForeignKey(d => d.SectionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrDepartmentSectionJob_HrDepartmentSections");
			});

			modelBuilder.Entity<HrDocument>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrEffect>(entity =>
			{
				entity.HasNoKey();

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FId)
					.ValueGeneratedOnAdd()
					.HasColumnName("fID");

				entity.Property(e => e.FType).HasColumnName("fType");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.SalaryItemId).HasColumnName("SalaryItemID");
			});

			modelBuilder.Entity<HrEmpCardNoHist>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpCardNoHist");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");
			});

			modelBuilder.Entity<HrEmpConcerned>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpConcerned");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.ConcerId).HasColumnName("ConcerID");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrEmpConcerneds)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrEmpConcerned_HrEndEmp");
			});

			modelBuilder.Entity<HrEmpDocument>(entity =>
			{
				entity.HasKey(e => new { e.EmpCode, e.DocCode });

				entity.Property(e => e.DocumentNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EndReleaseDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ReleaseDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ReleasePoint)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.DocCodeNavigation)
					.WithMany(p => p.HrEmpDocuments)
					.HasForeignKey(d => d.DocCode)
					.HasConstraintName("FK_HrEmpDocuments_HrDocuments");

				entity.HasOne(d => d.EmpCodeNavigation)
					.WithMany(p => p.HrEmpDocuments)
					.HasForeignKey(d => d.EmpCode)
					.HasConstraintName("FK_HrEmpDocuments_tblEmployees");
			});

			modelBuilder.Entity<HrEmpGroupType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpGroupType");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrEmpInCall>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpInCall");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrEmpInCallSett>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpInCallSett");

				entity.Property(e => e.FId).HasColumnName("fID");
			});

			modelBuilder.Entity<HrEmpItem>(entity =>
			{
				entity.HasKey(e => e.Fid)
					.HasName("PK_hrEmpItem");

				entity.ToTable("HrEmpItem");

				entity.Property(e => e.Fid).HasColumnName("fid");

				entity.Property(e => e.FValue)
					.HasColumnType("money")
					.HasColumnName("fValue");

				entity.Property(e => e.NotApp).HasComputedColumnSql("(case [App] when (0) then (1) else (0) end)", false);

				entity.Property(e => e.SumIt).HasComment("لاضافة الحقل إلى المجموع فى شاشة الربط");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrEmpItems)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrEmpItem_tblEmployees");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.HrEmpItems)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_HrEmpItem_HrSalaryItems");
			});

			modelBuilder.Entity<HrEmpItemHistoryDtl>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("PK_HrEmpItemHistory");

				entity.ToTable("HrEmpItemHistoryDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.DtlVal).HasColumnType("money");

				entity.Property(e => e.FHdrId).HasColumnName("fHdrId");

				entity.Property(e => e.NewValue)
					.HasColumnType("money")
					.HasComputedColumnSql("([OldValue]+[DtlVal])", false);

				entity.Property(e => e.NotApp).HasComputedColumnSql("(case [App] when (0) then (1) else (0) end)", false);

				entity.Property(e => e.OldValue).HasColumnType("money");

				entity.Property(e => e.SumIt).HasComment("لاضافة الحقل إلى المجموع فى شاشة الربط");

				entity.HasOne(d => d.FHdr)
					.WithMany(p => p.HrEmpItemHistoryDtls)
					.HasForeignKey(d => d.FHdrId)
					.HasConstraintName("FK_HrEmpItemHistory_HrEmpItemHistoryHdr");
			});

			modelBuilder.Entity<HrEmpItemHistoryHdr>(entity =>
			{
				entity.HasKey(e => e.FHdrId);

				entity.ToTable("HrEmpItemHistoryHdr");

				entity.Property(e => e.FHdrId)
					.ValueGeneratedNever()
					.HasColumnName("fHdrId");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FItemId).HasColumnName("fItemID");

				entity.Property(e => e.FPost).HasColumnName("fPost");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.IsValue)
					.IsRequired()
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<HrEmpStatus>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpStatus");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA");
			});

			modelBuilder.Entity<HrEmpVacType>(entity =>
			{
				entity.HasKey(e => new { e.EmpId, e.TypeId });

				entity.ToTable("HrEmpVacType");

				entity.Property(e => e.App)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrEmpVacTypes)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrEmpVacType_tblEmployees");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.HrEmpVacTypes)
					.HasForeignKey(d => d.TypeId)
					.HasConstraintName("FK_HrEmpVacType_HrVacType");
			});

			modelBuilder.Entity<HrEmpVacTypeCalc>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEmpVacTypeCalc");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FFrom).HasColumnName("fFrom");

				entity.Property(e => e.FTo).HasColumnName("fTo");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.VacTypeId).HasColumnName("VacTypeID");
			});

			modelBuilder.Entity<HrEmpWeekEnd>(entity =>
			{
				entity.HasKey(e => e.EmpId);

				entity.ToTable("HrEmpWeekEnd");

				entity.Property(e => e.EmpId)
					.ValueGeneratedNever()
					.HasColumnName("EmpID");

				entity.HasOne(d => d.Emp)
					.WithOne(p => p.HrEmpWeekEnd)
					.HasForeignKey<HrEmpWeekEnd>(d => d.EmpId)
					.HasConstraintName("FK_HrEmpWeekEnd_tblEmployees");
			});

			modelBuilder.Entity<HrEndEmp>(entity =>
			{
				entity.HasKey(e => e.EmpId);

				entity.ToTable("HrEndEmp");

				entity.Property(e => e.EmpId)
					.ValueGeneratedNever()
					.HasColumnName("EmpID");

				entity.Property(e => e.EndInsDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FReason)
					.HasMaxLength(200)
					.HasColumnName("fReason")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");
			});

			modelBuilder.Entity<HrEndServiceBonusEmp>(entity =>
			{
				entity.HasKey(e => e.EmpCode)
					.HasName("PK_HrEndServiceEmp");

				entity.ToTable("HrEndServiceBonusEmp");

				entity.Property(e => e.EmpCode).ValueGeneratedNever();

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.FValue)
					.HasColumnName("fValue")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.EmpCodeNavigation)
					.WithOne(p => p.HrEndServiceBonusEmp)
					.HasForeignKey<HrEndServiceBonusEmp>(d => d.EmpCode)
					.HasConstraintName("FK_HrEndServiceEmp_tblEmployees");
			});

			modelBuilder.Entity<HrEndServiceBonusSpecificDtl>(entity =>
			{
				entity.HasKey(e => e.DtlId);

				entity.ToTable("HrEndServiceBonusSpecificDtl");

				entity.Property(e => e.DtlId).HasColumnName("DtlID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.HasOne(d => d.Hdr)
					.WithMany(p => p.HrEndServiceBonusSpecificDtls)
					.HasForeignKey(d => d.HdrId)
					.HasConstraintName("FK_HrEndServiceBonusSpecificDtl_HrEndServiceBonusSpecificHdr");
			});

			modelBuilder.Entity<HrEndServiceBonusSpecificHdr>(entity =>
			{
				entity.HasKey(e => e.HdrId);

				entity.ToTable("HrEndServiceBonusSpecificHdr");

				entity.Property(e => e.HdrId)
					.ValueGeneratedNever()
					.HasColumnName("HdrID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
			});

			modelBuilder.Entity<HrEndServicePolicyDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrEndServicePolicyDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.EndServiceHdrNavigation)
					.WithMany(p => p.HrEndServicePolicyDtls)
					.HasForeignKey(d => d.EndServiceHdr)
					.HasConstraintName("FK_HrEndServicePolicyDtl_HrEndServicePolicyHdr");
			});

			modelBuilder.Entity<HrEndServicePolicyHdr>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("PK_HrEndServiceHdr");

				entity.ToTable("HrEndServicePolicyHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrEvalDeptItem>(entity =>
			{
				entity.HasKey(e => new { e.DepartmentId, e.EvalId });

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.EvalId).HasColumnName("EvalID");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.HrEvalDeptItems)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_HrEvalDeptItems_HrDepartment");

				entity.HasOne(d => d.Eval)
					.WithMany(p => p.HrEvalDeptItems)
					.HasForeignKey(d => d.EvalId)
					.HasConstraintName("FK_HrEvalDeptItems_HrEvalItems");
			});

			modelBuilder.Entity<HrEvalDtl>(entity =>
			{
				entity.HasKey(e => new { e.EvalHdr, e.EmpId, e.EvalId });

				entity.ToTable("HrEvalDtl");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.EvalId).HasColumnName("EvalID");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrEvalDtls)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrEvalDtl_tblEmployees");

				entity.HasOne(d => d.EvalHdrNavigation)
					.WithMany(p => p.HrEvalDtls)
					.HasForeignKey(d => d.EvalHdr)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrEvalDtl_HrEvalHdr");

				entity.HasOne(d => d.Eval)
					.WithMany(p => p.HrEvalDtls)
					.HasForeignKey(d => d.EvalId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrEvalDtl_HrEvalItems");
			});

			modelBuilder.Entity<HrEvalHdr>(entity =>
			{
				entity.HasKey(e => e.EvalHdr);

				entity.ToTable("HrEvalHdr");

				entity.Property(e => e.EvalHdr).ValueGeneratedNever();

				entity.Property(e => e.EvalName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate");

				entity.Property(e => e.FDesc)
					.HasMaxLength(250)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FromDate)
					.HasColumnType("datetime")
					.HasColumnName("fromDate");

				entity.Property(e => e.Todate)
					.HasColumnType("datetime")
					.HasColumnName("todate");
			});

			modelBuilder.Entity<HrEvalItem>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrExchangeTicket>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrExchangeTicket");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.Destination)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.TicketAllowence).HasComment("replace ticket with money");

				entity.HasOne(d => d.EmpCodeNavigation)
					.WithMany(p => p.HrExchangeTickets)
					.HasForeignKey(d => d.EmpCode)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrExchangeTicket_tblEmployees");
			});

			modelBuilder.Entity<HrFingerPrintHist>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrFingerPrintHist");

				entity.Property(e => e.DayVal)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FType)
					.HasColumnName("fType")
					.HasComment("0 for Machine or table 1 for Manual");

				entity.Property(e => e.StateVal)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TimeVal)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<HrHoliday>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDay).HasColumnName("fDay");

				entity.Property(e => e.FDesc)
					.HasMaxLength(150)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FMonth).HasColumnName("fMonth");

				entity.Property(e => e.FType)
					.HasColumnName("fType")
					.HasComment("0 for Holidays , 1 for WeekEnd");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.FYear).HasColumnName("fYear");
			});

			modelBuilder.Entity<HrIncentiveDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrIncentiveDtl");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FIdhdr).HasColumnName("fIDHdr");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.FIdhdrNavigation)
					.WithMany(p => p.HrIncentiveDtls)
					.HasForeignKey(d => d.FIdhdr)
					.HasConstraintName("FK_HrIncentiveDtl_HrIncentiveHdr");
			});

			modelBuilder.Entity<HrIncentiveHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrIncentiveHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrIncentiveSalaryDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrIncentiveSalaryDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FHdr).HasColumnName("fHdr");

				entity.HasOne(d => d.FHdrNavigation)
					.WithMany(p => p.HrIncentiveSalaryDtls)
					.HasForeignKey(d => d.FHdr)
					.HasConstraintName("FK_HrIncentiveSalaryDtl_HrIncentiveSalaryHdr");
			});

			modelBuilder.Entity<HrIncentiveSalaryHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrIncentiveSalaryHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FValue).HasColumnName("fValue");
			});

			modelBuilder.Entity<HrInstPayDtl>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrInstPayDtl");

				entity.Property(e => e.FBranchId).HasColumnName("fBranchID");

				entity.Property(e => e.FDeleted)
					.HasColumnName("fDeleted")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FPayAmount)
					.HasColumnType("decimal(18, 0)")
					.HasColumnName("fPayAmount");

				entity.Property(e => e.FPayCode).HasColumnName("fPayCode");

				entity.Property(e => e.FPayInvoice).HasColumnName("fPayInvoice");

				entity.Property(e => e.FRepDate)
					.HasColumnType("datetime")
					.HasColumnName("fRepDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FReplicated)
					.HasColumnName("fReplicated")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.PayInvDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<HrInstPayHdr>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrInstPayHdr");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FBranchId).HasColumnName("fBranchID");

				entity.Property(e => e.FDeleted)
					.HasColumnName("fDeleted")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FNotes)
					.HasMaxLength(50)
					.HasColumnName("fNotes")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPayCode)
					.HasColumnName("fPayCode")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FPayDate)
					.HasColumnType("datetime")
					.HasColumnName("fPayDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FPayDesc)
					.HasMaxLength(60)
					.HasColumnName("fPayDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPayType)
					.HasColumnName("fPayType")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FPayValue)
					.HasColumnType("money")
					.HasColumnName("fPayValue")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FPerson)
					.HasMaxLength(50)
					.HasColumnName("fPerson")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.FReceiptNo)
					.HasMaxLength(50)
					.HasColumnName("fReceiptNo")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FRepDate)
					.HasColumnType("datetime")
					.HasColumnName("fRepDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FReplicated)
					.HasColumnName("fReplicated")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.PrePaidId).HasColumnName("PrePaidID");
			});

			modelBuilder.Entity<HrInsuranceDegree>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrInsuranceDegree");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(250)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrInsuranceOffice>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrInsuranceOffice");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.Area)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BuildingNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Central)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ContractBegin)
					.HasColumnType("date")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ContractEnd)
					.HasColumnType("date")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Govern)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Street)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Village)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrJob>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

				entity.Property(e => e.EmpCount).HasDefaultValueSql("((1))");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FIdhdr).HasColumnName("fIDHdr");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.JobTask)
					.HasMaxLength(512)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MedicalInuranceDegree)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SIdlevels)
					.HasMaxLength(50)
					.HasColumnName("sIDLevels")
					.HasComputedColumnSql("([dbo].[sIDLevels]([fid]))", false);

				entity.HasOne(d => d.Degree)
					.WithMany(p => p.HrJobs)
					.HasForeignKey(d => d.DegreeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrJobs_HrJobDegrees");
			});

			modelBuilder.Entity<HrJobDegree>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("PK_HrSalaryDegrees");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLayoffType>(entity =>
			{
				entity.HasKey(e => e.TypeId)
					.HasName("PK_HrLayOff");

				entity.ToTable("HrLayoffType");

				entity.Property(e => e.TypeId)
					.ValueGeneratedNever()
					.HasColumnName("TypeID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLegCost>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLegationClose>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrLegationClose");

				entity.Property(e => e.FId).HasColumnName("fId");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.Property(e => e.Normal)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Reason)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLegationDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrLegationDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.CostId).HasColumnName("CostID");

				entity.Property(e => e.FPayed).HasColumnName("fPayed");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.IdHdrNavigation)
					.WithMany(p => p.HrLegationDtls)
					.HasForeignKey(d => d.IdHdr)
					.HasConstraintName("FK_HrLegationDtl_HrLegationHdr");
			});

			modelBuilder.Entity<HrLegationExtensionDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrLegationExtensionDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.CostId).HasColumnName("CostID");

				entity.Property(e => e.FPayed).HasColumnName("fPayed");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.IdHdrNavigation)
					.WithMany(p => p.HrLegationExtensionDtls)
					.HasForeignKey(d => d.IdHdr)
					.HasConstraintName("FK_HrLegationExtensionDtl_HrLegationExtensionHdr");
			});

			modelBuilder.Entity<HrLegationExtensionHdr>(entity =>
			{
				entity.HasKey(e => e.HdrId);

				entity.ToTable("HrLegationExtensionHdr");

				entity.Property(e => e.HdrId)
					.ValueGeneratedNever()
					.HasColumnName("HdrID");

				entity.Property(e => e.Increase)
					.IsRequired()
					.HasDefaultValueSql("((1))")
					.HasComment("0 For Decreaese 1 For Increase");

				entity.Property(e => e.LegationId).HasColumnName("LegationID");

				entity.Property(e => e.ToDateNew)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLegationHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrLegationHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.CountryId).HasColumnName("CountryID");

				entity.Property(e => e.Destination)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FType)
					.HasColumnName("fType")
					.HasComment("0 for Inner 1 for Outer");

				entity.Property(e => e.FromDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LastDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ToDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrLegationPay>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrLegationPay");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FBranch).HasColumnName("fBranch");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.Property(e => e.PayType).HasComment("0 for Cash 1 for Salary item");

				entity.Property(e => e.SaftyId).HasColumnName("SaftyID");

				entity.Property(e => e.SalaryItemId).HasColumnName("SalaryItemID");
			});

			modelBuilder.Entity<HrLoanType>(entity =>
			{
				entity.HasKey(e => e.TypeId);

				entity.ToTable("HrLoanType");

				entity.Property(e => e.TypeId)
					.ValueGeneratedNever()
					.HasColumnName("TypeID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.SalaryItemNavigation)
					.WithMany(p => p.HrLoanTypes)
					.HasForeignKey(d => d.SalaryItem)
					.HasConstraintName("FK_HrLoanType_HrSalaryItems");
			});

			modelBuilder.Entity<HrLoansDtl>(entity =>
			{
				entity.HasKey(e => new { e.LoanId, e.InstCode });

				entity.ToTable("HrLoansDtl");

				entity.Property(e => e.LoanId).HasColumnName("LoanID");

				entity.Property(e => e.InstDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.InstVal).HasColumnType("money");

				entity.Property(e => e.ItemId).HasColumnName("ItemID");

				entity.Property(e => e.Paid).HasColumnType("money");

				entity.Property(e => e.Remain)
					.HasColumnType("money")
					.HasComputedColumnSql("([InstVal]-[paid])", false);

				entity.Property(e => e.SalaryId).HasColumnName("SalaryID");

				entity.HasOne(d => d.Loan)
					.WithMany(p => p.HrLoansDtls)
					.HasForeignKey(d => d.LoanId)
					.HasConstraintName("FK_HrLoansDtl_HrLoansHdr");
			});

			modelBuilder.Entity<HrLoansHdr>(entity =>
			{
				entity.HasKey(e => e.LoanId)
					.HasName("PK_HrLoans");

				entity.ToTable("HrLoansHdr");

				entity.Property(e => e.LoanId)
					.ValueGeneratedNever()
					.HasColumnName("LoanID");

				entity.Property(e => e.AccountId)
					.HasMaxLength(30)
					.HasColumnName("AccountID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BankId).HasColumnName("BankID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CashId).HasColumnName("CashID");

				entity.Property(e => e.Dwflinked).HasColumnName("DWFLinked");

				entity.Property(e => e.Dwfstatus).HasColumnName("DWFStatus");

				entity.Property(e => e.DwfstatusDescription)
					.HasMaxLength(50)
					.HasColumnName("DWFStatusDescription")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FCurCode).HasColumnName("fCurCode");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FirstDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Guarantor)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.InstValue).HasColumnType("money");

				entity.Property(e => e.LastDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.LoanVal).HasColumnType("money");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PayType).HasComment("1-Cash         2-Cheaque");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrLoansHdrs)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrLoansHdr_tblEmployees");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.HrLoansHdrs)
					.HasForeignKey(d => d.TypeId)
					.HasConstraintName("FK_HrLoansHdr_HrLoanType");
			});

			modelBuilder.Entity<HrLogInfo>(entity =>
			{
				entity.HasKey(e => e.LogId)
					.HasName("PK_HrLoginfo");

				entity.ToTable("HrLogInfo");

				entity.Property(e => e.LogId).HasColumnName("logId");

				entity.Property(e => e.AbsentReason)
					.HasMaxLength(512)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArriveAt).HasColumnType("datetime");

				entity.Property(e => e.ArriveTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 8:00:00 AM')");

				entity.Property(e => e.ArriveTime1)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 8:00:00 AM')");

				entity.Property(e => e.DelayTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 8:00:00 AM')");

				entity.Property(e => e.Description)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.GroupId).HasColumnName("GroupID");

				entity.Property(e => e.LeaveAt).HasColumnType("datetime");

				entity.Property(e => e.LeaveTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 5:00:00 PM')");

				entity.Property(e => e.LeaveTime1)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 5:00:00 PM')");

				entity.Property(e => e.LogDate)
					.HasColumnType("datetime")
					.HasColumnName("logDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OverTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('3/1/2006 5:00:00 PM')");

				entity.Property(e => e.StatusId).HasColumnName("StatusID");

				entity.Property(e => e.WorkMinutes).HasComputedColumnSql("(datepart(hour,[LeaveTime]-[ArriveTime])*(60)+datepart(minute,[LeaveTime]-[ArriveTime]))", false);

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrLogInfos)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrLogInfo_tblEmployees");
			});

			modelBuilder.Entity<HrLogInfoHist>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrLogInfoHist");

				entity.Property(e => e.DayVal)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.StateVal)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TimeVal)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<HrMachineSet>(entity =>
			{
				entity.HasKey(e => e.Code);

				entity.ToTable("HrMachineSet");

				entity.Property(e => e.BaudRate)
					.HasMaxLength(50)
					.HasColumnName("Baud_Rate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ComKey)
					.HasMaxLength(50)
					.HasColumnName("Com_Key")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ComType)
					.HasMaxLength(50)
					.HasColumnName("Com_Type")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.DevNo).HasColumnName("Dev_No");

				entity.Property(e => e.IpAddress)
					.HasMaxLength(50)
					.HasColumnName("Ip_Address")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MachineName)
					.HasMaxLength(50)
					.HasColumnName("Machine_Name")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PortName)
					.HasMaxLength(50)
					.HasColumnName("Port_Name")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.StateAtt)
					.HasMaxLength(50)
					.HasDefaultValueSql("('0')");

				entity.Property(e => e.StateIn)
					.HasMaxLength(50)
					.HasDefaultValueSql("('2')");

				entity.Property(e => e.StateIn1)
					.HasMaxLength(50)
					.HasDefaultValueSql("('2')");

				entity.Property(e => e.StateIn2)
					.HasMaxLength(50)
					.HasDefaultValueSql("('2')");

				entity.Property(e => e.StateIn3)
					.HasMaxLength(50)
					.HasDefaultValueSql("('2')");

				entity.Property(e => e.StateIn4)
					.HasMaxLength(50)
					.HasDefaultValueSql("('2')");

				entity.Property(e => e.StateLeave)
					.HasMaxLength(50)
					.HasDefaultValueSql("('1')");

				entity.Property(e => e.StateOut)
					.HasMaxLength(50)
					.HasDefaultValueSql("('3')");

				entity.Property(e => e.StateOut1)
					.HasMaxLength(50)
					.HasDefaultValueSql("('3')");

				entity.Property(e => e.StateOut2)
					.HasMaxLength(50)
					.HasDefaultValueSql("('3')");

				entity.Property(e => e.StateOut3)
					.HasMaxLength(50)
					.HasDefaultValueSql("('3')");

				entity.Property(e => e.StateOut4)
					.HasMaxLength(50)
					.HasDefaultValueSql("('3')");
			});

			modelBuilder.Entity<HrMaritalStatus>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrMaritalStatus");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrMartialStatus>(entity =>
			{
				entity.HasKey(e => e.MartialStatusId)
					.HasName("PK_HrMartialSts");

				entity.ToTable("HrMartialStatus");

				entity.Property(e => e.MartialStatusId)
					.ValueGeneratedNever()
					.HasColumnName("MartialStatusID");

				entity.Property(e => e.FName)
					.HasMaxLength(20)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(20)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrMedicalInsuranceType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrNationality>(entity =>
			{
				entity.HasKey(e => e.NationalityId);

				entity.ToTable("HrNationality");

				entity.Property(e => e.NationalityId)
					.ValueGeneratedNever()
					.HasColumnName("NationalityID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrNominationType>(entity =>
			{
				entity.HasKey(e => e.NominationTypeId);

				entity.ToTable("HrNominationType");

				entity.Property(e => e.NominationTypeId)
					.ValueGeneratedNever()
					.HasColumnName("NominationTypeID");

				entity.Property(e => e.FName)
					.HasMaxLength(20)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(20)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrOptionDtlAttendance>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrOptionDtlAttendance");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.HasOne(d => d.Hdr)
					.WithMany(p => p.HrOptionDtlAttendances)
					.HasForeignKey(d => d.HdrId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrOptionDtlAttendance_HrOptionHdr");
			});

			modelBuilder.Entity<HrOptionDtlGeneral>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrOptionDtlGeneral");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.AbsentDays)
					.HasMaxLength(50)
					.HasComment("Sun,Mon,Tues,Wed,Thurs,Frid,Sat");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");
			});

			modelBuilder.Entity<HrOptionDtlLeave>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrOptionDtlLeave");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");
			});

			modelBuilder.Entity<HrOptionDtlPermission>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrOptionDtlPermission");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");
			});

			modelBuilder.Entity<HrOptionHdr>(entity =>
			{
				entity.HasKey(e => e.HdrId);

				entity.ToTable("HrOptionHdr");

				entity.Property(e => e.HdrId)
					.ValueGeneratedNever()
					.HasColumnName("HdrID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName");
			});

			modelBuilder.Entity<HrPRType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrP_R_Types");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID")
					.HasComment("انواع المكافآت والجزاءات");

				entity.Property(e => e.FDesc)
					.HasMaxLength(150)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrPdeptItem>(entity =>
			{
				entity.HasKey(e => new { e.PolicyId, e.DepartmentId, e.ItemId })
					.HasName("PK_HrPRelation");

				entity.ToTable("HrPDeptItem");

				entity.Property(e => e.PolicyId)
					.HasColumnName("Policy_ID")
					.HasComment("Policy ID in HrPPolicy");

				entity.Property(e => e.DepartmentId)
					.HasColumnName("DepartmentID")
					.HasComment("Department Id in HrDepartment");

				entity.Property(e => e.ItemId).HasComment("Salry Item ID in HrSalaryItem table");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.HrPdeptItems)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_HrPRelation_HrDepartment");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.HrPdeptItems)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_HrPRelation_HrSalaryItems");

				entity.HasOne(d => d.Policy)
					.WithMany(p => p.HrPdeptItems)
					.HasForeignKey(d => d.PolicyId)
					.HasConstraintName("FK_HrPRelation_HrPPolicy");
			});

			modelBuilder.Entity<HrPdeptItemEmp>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrPDeptItemEmps");

				entity.Property(e => e.DepartmentId)
					.HasColumnName("DepartmentID")
					.HasComment("Department Id in HrDepartment");

				entity.Property(e => e.ItemId).HasComment("Salry Item ID in HrSalaryItem table");

				entity.Property(e => e.PolicyId)
					.HasColumnName("Policy_ID")
					.HasComment("Policy ID in HrPPolicy");
			});

			modelBuilder.Entity<HrPermissionDtl>(entity =>
			{
				entity.HasKey(e => new { e.HdrCode, e.EmpCode });

				entity.ToTable("HrPermissionDtl");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.EmpCodeNavigation)
					.WithMany(p => p.HrPermissionDtls)
					.HasForeignKey(d => d.EmpCode)
					.HasConstraintName("FK_HrPermissionDtl_tblEmployees");

				entity.HasOne(d => d.HdrCodeNavigation)
					.WithMany(p => p.HrPermissionDtls)
					.HasForeignKey(d => d.HdrCode)
					.HasConstraintName("FK_HrPermissionDtl_HrPermissionHdr");
			});

			modelBuilder.Entity<HrPermissionHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrPermissionHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.ApplyPolicy)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasDefaultValueSql("((0))")
					.IsFixedLength()
					.HasComment("0 No Policy 1 Delay Policy 2 Permission Policy");

				entity.Property(e => e.DateTimeFrom)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DateTimeTo)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Dwflinked).HasColumnName("DWFLinked");

				entity.Property(e => e.Dwfstatus).HasColumnName("DWFStatus");

				entity.Property(e => e.DwfstatusDescription)
					.HasMaxLength(50)
					.HasColumnName("DWFStatusDescription")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FType)
					.HasColumnName("fType")
					.HasDefaultValueSql("((1))")
					.HasComment("1 for permissons 2 for missions");
			});

			modelBuilder.Entity<HrPost>(entity =>
			{
				entity.HasKey(e => e.Fid)
					.HasName("pk_HrPost");

				entity.ToTable("HrPost");

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrPperiod>(entity =>
			{
				entity.HasKey(e => e.PeriodId);

				entity.ToTable("HrPPeriods");

				entity.Property(e => e.PeriodId)
					.ValueGeneratedNever()
					.HasColumnName("Period_ID")
					.HasComment("الفترات");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PeriodFrom).HasColumnName("Period_From");

				entity.Property(e => e.PeriodTo).HasColumnName("Period_To");
			});

			modelBuilder.Entity<HrPpolicy>(entity =>
			{
				entity.HasKey(e => e.PolicyId)
					.HasName("PK_HrPolicy");

				entity.ToTable("HrPPolicy");

				entity.Property(e => e.PolicyId)
					.ValueGeneratedNever()
					.HasColumnName("Policy_ID");

				entity.Property(e => e.Allowance).HasComment("Allowance in Minutes for policy");

				entity.Property(e => e.EffectInLeaves).HasComment("if 1 then delay only with Policy_type 0 ignore department relation");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PolicyType)
					.HasColumnName("Policy_type")
					.HasComment("0 for Late and 1 for Over time 2 for Absence without permission 3 for Attend in Holiday  4 for Permission Delay 5 for Mission Delay 20 for absent without permission 7 For Leave Befor Time");
			});

			modelBuilder.Entity<HrProjectDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrProjectDtl");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.FHdr).HasColumnName("fHdr");

				entity.Property(e => e.SubLocation)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.FHdrNavigation)
					.WithMany(p => p.HrProjectDtls)
					.HasForeignKey(d => d.FHdr)
					.HasConstraintName("FK_HrProjectDtl_HrProjectHdr");
			});

			modelBuilder.Entity<HrProjectEmpBind>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrProjectEmpBind");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FromDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

				entity.Property(e => e.ToDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrProjectHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrProjectHdr");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrProjectHourDistDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrProjectHourDistDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.FHdrId).HasColumnName("fHdrId");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.HasOne(d => d.FHdr)
					.WithMany(p => p.HrProjectHourDistDtls)
					.HasForeignKey(d => d.FHdrId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrProjectHourDistDtl_HrProjectHourDistHdr");
			});

			modelBuilder.Entity<HrProjectHourDistHdr>(entity =>
			{
				entity.HasKey(e => e.FHdrId);

				entity.ToTable("HrProjectHourDistHdr");

				entity.Property(e => e.FHdrId)
					.ValueGeneratedNever()
					.HasColumnName("fHdrId");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrPtime>(entity =>
			{
				entity.HasKey(e => e.TimeId);

				entity.ToTable("HrPTimes");

				entity.Property(e => e.TimeId)
					.ValueGeneratedNever()
					.HasColumnName("Time_Id");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrPtimesPeriod>(entity =>
			{
				entity.HasKey(e => new { e.PolicyId, e.TimeId, e.PeriodId })
					.HasName("PK_hrPTimesPeriod");

				entity.ToTable("HrPTimesPeriod");

				entity.Property(e => e.PolicyId).HasColumnName("Policy_ID");

				entity.Property(e => e.TimeId).HasColumnName("Time_Id");

				entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

				entity.Property(e => e.TimeValue).HasColumnName("Time_Value");

				entity.HasOne(d => d.Policy)
					.WithMany(p => p.HrPtimesPeriods)
					.HasForeignKey(d => d.PolicyId)
					.HasConstraintName("FK_hrPTimesPeriod_HrPPolicy");

				entity.HasOne(d => d.Time)
					.WithMany(p => p.HrPtimesPeriods)
					.HasForeignKey(d => d.TimeId)
					.HasConstraintName("FK_hrPTimesPeriod_HrPTimes");
			});

			modelBuilder.Entity<HrPunRewDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrPunRewDtl");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.Property(e => e.SalaryItemId)
					.HasColumnName("SalaryItemID")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.Val).HasDefaultValueSql("((0))");

				entity.HasOne(d => d.Hdr)
					.WithMany(p => p.HrPunRewDtls)
					.HasForeignKey(d => d.HdrId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_HrPunRewDtl_HrPunRewHDR");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.HrPunRewDtls)
					.HasForeignKey(d => d.TypeId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_HrPunRewDtl_HrPunRewTypes");
			});

			modelBuilder.Entity<HrPunRewHdr>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrPunRewHDR");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate");

				entity.Property(e => e.FDesc)
					.HasMaxLength(300)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TypeId)
					.HasColumnName("TypeID")
					.HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.HrPunRewHdrs)
					.HasForeignKey(d => d.TypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrPunRewHDR_HrP_R_Types");
			});

			modelBuilder.Entity<HrPunRewType>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("PK_HRPunRewTypes");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.DefVal).HasComment("Default Value");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')")
					.HasComment("Description");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TypeId)
					.HasColumnName("TypeID")
					.HasDefaultValueSql("((1))")
					.HasComment("1 or 2 as for Rewards and Punishment");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.HrPunRewTypes)
					.HasForeignKey(d => d.TypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrPunRewTypes_HrP_R_Types");
			});

			modelBuilder.Entity<HrPunishment>(entity =>
			{
				entity.HasKey(e => e.Fid);

				entity.ToTable("HrPunishment");

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.Fdate)
					.HasColumnType("datetime")
					.HasColumnName("fdate");

				entity.Property(e => e.Fdesc)
					.HasMaxLength(50)
					.HasColumnName("fdesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fpost)
					.HasColumnName("fpost")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Fvalue)
					.HasColumnType("money")
					.HasColumnName("fvalue")
					.HasDefaultValueSql("((0))");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrPunishments)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrPunishment_tblEmployees");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.HrPunishments)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_HrPunishment_HrSalaryItems");
			});

			modelBuilder.Entity<HrRecApplicationQues1>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRecApplicationQues1");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.JobApplicationId).HasColumnName("JobApplicationID");

				entity.Property(e => e.QuestinId).HasColumnName("QuestinID");

				entity.HasOne(d => d.JobApplication)
					.WithMany(p => p.HrRecApplicationQues1s)
					.HasForeignKey(d => d.JobApplicationId)
					.HasConstraintName("FK_HrRecApplicationQues1_HrRecJobApplication");

				entity.HasOne(d => d.Questin)
					.WithMany(p => p.HrRecApplicationQues1s)
					.HasForeignKey(d => d.QuestinId)
					.HasConstraintName("FK_HrRecApplicationQues1_HrRecApplicationQuestion");
			});

			modelBuilder.Entity<HrRecApplicationQues2>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRecApplicationQues2");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.CompJob)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CompTel)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CompanyName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.JobApplicationId).HasColumnName("JobApplicationID");

				entity.Property(e => e.LeaveworkReason)
					.HasMaxLength(312)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ManagerName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.WorkFrom)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.WorkTo)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.JobApplication)
					.WithMany(p => p.HrRecApplicationQues2s)
					.HasForeignKey(d => d.JobApplicationId)
					.HasConstraintName("FK_HrRecApplicationQues2_HrRecJobApplication");
			});

			modelBuilder.Entity<HrRecApplicationQuestion>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRecApplicationQuestion");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrRecJobApplication>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRecJobApplication");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.Age).HasComputedColumnSql("(datediff(year,[fBirth],[ApplicationDate]))", false);

				entity.Property(e => e.ApplicationDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Area)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BloodType)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Central)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FAddress)
					.HasMaxLength(80)
					.HasColumnName("fAddress")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FBirth)
					.HasColumnType("datetime")
					.HasColumnName("fBirth")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FGender).HasColumnName("fGender");

				entity.Property(e => e.FIdno)
					.HasMaxLength(25)
					.HasColumnName("fIDNo");

				entity.Property(e => e.FMobileNo)
					.HasMaxLength(50)
					.HasColumnName("fMobileNo");

				entity.Property(e => e.FStatus).HasColumnName("fStatus");

				entity.Property(e => e.FTelephone)
					.HasMaxLength(20)
					.HasColumnName("fTelephone")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FYearsMarige).HasColumnName("fYearsMarige");

				entity.Property(e => e.FatherJob)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FatherMobile)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FirstName)
					.HasMaxLength(50)
					.HasColumnName("firstName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FourthName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Government)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Graduation).HasColumnType("datetime");

				entity.Property(e => e.IdDate)
					.HasColumnType("datetime")
					.HasColumnName("ID_Date")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IdIssuer)
					.HasMaxLength(50)
					.HasColumnName("ID_Issuer")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MartialStatusId).HasColumnName("MartialStatusID");

				entity.Property(e => e.MilitryDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Qualification)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RelativeMobile)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RelativeName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Religion).HasMaxLength(50);

				entity.Property(e => e.Residence)
					.HasMaxLength(312)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SecondName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ThirdName).HasMaxLength(50);

				entity.Property(e => e.University)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.FStatusNavigation)
					.WithMany(p => p.HrRecJobApplications)
					.HasForeignKey(d => d.FStatus)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecJobApplication_HrMaritalStatus");

				entity.HasOne(d => d.MartialStatus)
					.WithMany(p => p.HrRecJobApplications)
					.HasForeignKey(d => d.MartialStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecJobApplication_HrMartialStatus");
			});

			modelBuilder.Entity<HrRecrCvdtl>(entity =>
			{
				entity.HasKey(e => e.CvdtlId);

				entity.ToTable("HrRecrCVDtl");

				entity.Property(e => e.CvdtlId).HasColumnName("CVDtlID");

				entity.Property(e => e.Cvid).HasColumnName("CVID");

				entity.Property(e => e.FRecItemId).HasColumnName("fRecItemID");

				entity.Property(e => e.FRecItemName)
					.HasMaxLength(50)
					.HasColumnName("fRecItemName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FRecItemNameA)
					.HasMaxLength(50)
					.HasColumnName("fRecItemNameA")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Cv)
					.WithMany(p => p.HrRecrCvdtls)
					.HasForeignKey(d => d.Cvid)
					.HasConstraintName("FK_HrRecrCVDtl_HrRecrCVHdr");

				entity.HasOne(d => d.FRecItem)
					.WithMany(p => p.HrRecrCvdtls)
					.HasForeignKey(d => d.FRecItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecrCVDtl_HrRecrItems");
			});

			modelBuilder.Entity<HrRecrCvhdr>(entity =>
			{
				entity.HasKey(e => e.Cvid);

				entity.ToTable("HrRecrCVHdr");

				entity.Property(e => e.Cvid)
					.ValueGeneratedNever()
					.HasColumnName("CVID");

				entity.Property(e => e.FAddress)
					.HasMaxLength(50)
					.HasColumnName("fAddress")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FEmail)
					.HasMaxLength(50)
					.HasColumnName("fEmail")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FMobile)
					.HasMaxLength(50)
					.HasColumnName("fMobile")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FTelephone)
					.HasMaxLength(20)
					.HasColumnName("fTelephone")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.RecJob)
					.WithMany(p => p.HrRecrCvhdrs)
					.HasForeignKey(d => d.RecJobId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecrCVHdr_HrRecrJobsHdr");
			});

			modelBuilder.Entity<HrRecrInterViewDtl>(entity =>
			{
				entity.HasKey(e => e.InterviewDtlId);

				entity.ToTable("HrRecrInterViewDtl");

				entity.Property(e => e.InterviewDtlId).HasColumnName("InterviewDtlID");

				entity.Property(e => e.Cvid).HasColumnName("CVID");

				entity.Property(e => e.FDegree).HasColumnName("fDegree");

				entity.Property(e => e.FNotes)
					.HasMaxLength(255)
					.HasColumnName("fNotes")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FRecItemId).HasColumnName("fRecItemID");

				entity.Property(e => e.FUserId).HasColumnName("fUserID");

				entity.Property(e => e.InterviewHdrId).HasColumnName("InterviewHdrID");

				entity.HasOne(d => d.Cv)
					.WithMany(p => p.HrRecrInterViewDtls)
					.HasForeignKey(d => d.Cvid)
					.HasConstraintName("FK_HrRecrInterViewDtl_HrRecrCVHdr");

				entity.HasOne(d => d.FRecItem)
					.WithMany(p => p.HrRecrInterViewDtls)
					.HasForeignKey(d => d.FRecItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecrInterViewDtl_HrRecrItems");

				entity.HasOne(d => d.InterviewHdr)
					.WithMany(p => p.HrRecrInterViewDtls)
					.HasForeignKey(d => d.InterviewHdrId)
					.HasConstraintName("FK_HrRecrInterViewDtl_HrRecrInterViewHdr");
			});

			modelBuilder.Entity<HrRecrInterViewHdr>(entity =>
			{
				entity.HasKey(e => e.InterviewHdrId);

				entity.ToTable("HrRecrInterViewHdr");

				entity.Property(e => e.InterviewHdrId)
					.ValueGeneratedNever()
					.HasColumnName("InterviewHdrID");
			});

			modelBuilder.Entity<HrRecrItem>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FValue).HasColumnName("fValue");
			});

			modelBuilder.Entity<HrRecrJobsDtl>(entity =>
			{
				entity.HasKey(e => e.FIddtl);

				entity.ToTable("HrRecrJobsDtl");

				entity.Property(e => e.FIddtl).HasColumnName("fIDDtl");

				entity.Property(e => e.FHdrId).HasColumnName("fHdrID");

				entity.Property(e => e.FRecItemId).HasColumnName("fRecItemID");

				entity.Property(e => e.FRecItemName)
					.HasMaxLength(50)
					.HasColumnName("fRecItemName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FRecItemNameA)
					.HasMaxLength(50)
					.HasColumnName("fRecItemNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fvalue).HasColumnName("fvalue");

				entity.Property(e => e.Stage).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.FHdr)
					.WithMany(p => p.HrRecrJobsDtls)
					.HasForeignKey(d => d.FHdrId)
					.HasConstraintName("FK_HrRecrJobsDtl_HrRecrJobsHdr");

				entity.HasOne(d => d.FRecItem)
					.WithMany(p => p.HrRecrJobsDtls)
					.HasForeignKey(d => d.FRecItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecrJobsDtl_HrRecrItems");
			});

			modelBuilder.Entity<HrRecrJobsHdr>(entity =>
			{
				entity.HasKey(e => e.FIdhdr);

				entity.ToTable("HrRecrJobsHdr");

				entity.Property(e => e.FIdhdr)
					.ValueGeneratedNever()
					.HasColumnName("fIDHdr");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDesc)
					.HasMaxLength(255)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FromDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ToDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Job)
					.WithMany(p => p.HrRecrJobsHdrs)
					.HasForeignKey(d => d.JobId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HrRecrJobs_HrJobs");
			});

			modelBuilder.Entity<HrRecrState>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRecrState");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrRelationType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrRelationType");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrReward>(entity =>
			{
				entity.HasKey(e => e.Fid);

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.Fdate)
					.HasColumnType("datetime")
					.HasColumnName("fdate");

				entity.Property(e => e.Fdesc)
					.HasMaxLength(50)
					.HasColumnName("fdesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fpost)
					.HasColumnName("fpost")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Fvalue)
					.HasColumnType("money")
					.HasColumnName("fvalue")
					.HasDefaultValueSql("((0))");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrRewards)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrRewards_tblEmployees");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.HrRewards)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_HrRewards_HrSalaryItems");
			});

			modelBuilder.Entity<HrSalaryBound>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("PK_HrBounds");

				entity.Property(e => e.FId)
					.HasColumnName("fID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrSalaryDtl>(entity =>
			{
				entity.HasKey(e => new { e.EmpId, e.ItemId, e.SalaryId });

				entity.ToTable("HrSalaryDTL");

				entity.Property(e => e.CanInsurance)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CanTax)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.EffectValue).HasComment("");

				entity.Property(e => e.FDesc)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.InsuranceValComp).HasComputedColumnSql("(((([fvalue]*[itemvalue])*[AddLess])*[InsuranceComp])*[CanInsurance])", false);

				entity.Property(e => e.Total)
					.HasColumnName("total")
					.HasComputedColumnSql("((([fvalue]+[EffectValue])*[itemvalue])*[AddLess])", false);

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrSalaryDtls)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrSalaryDTL_tblEmployees");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.HrSalaryDtls)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_HrSalaryDTL_HrSalaryItems");

				entity.HasOne(d => d.Salary)
					.WithMany(p => p.HrSalaryDtls)
					.HasForeignKey(d => d.SalaryId)
					.HasConstraintName("FK_HrSalaryDTL_HrSalaryHDR");
			});

			modelBuilder.Entity<HrSalaryEmpDtl>(entity =>
			{
				entity.HasKey(e => new { e.SalaryId, e.EmpId });

				entity.ToTable("HrSalaryEmpDTL");

				entity.Property(e => e.SalaryId).HasColumnName("SalaryID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.BasicInsuranceComp).HasColumnType("money");

				entity.Property(e => e.BasicInsuranceEmp).HasColumnType("money");

				entity.Property(e => e.BasicTotal).HasColumnType("money");

				entity.Property(e => e.CashPay).HasComment("Salary Payment type");

				entity.Property(e => e.ChangeInsuranceComp).HasColumnType("money");

				entity.Property(e => e.ChangeInsuranceEmp).HasColumnType("money");

				entity.Property(e => e.ChangeTotal).HasColumnType("money");

				entity.Property(e => e.DeductionTotal).HasColumnType("money");

				entity.Property(e => e.FirstPayWay).HasComment("Branch or bank depond on CashPay field");

				entity.Property(e => e.IncomeCalcTax)
					.HasColumnType("money")
					.HasComment("الدخل الخاضع للضريبه");

				entity.Property(e => e.Insurance).HasColumnType("money");

				entity.Property(e => e.PostPay).HasComment("Salary Payment Post");

				entity.Property(e => e.SavePay).HasComment("Salary Payment Save");

				entity.Property(e => e.SecondPayWay).HasComment("safe or acc No depond on CashPay field");

				entity.Property(e => e.TaxLimitFree)
					.HasColumnType("money")
					.HasComment("حد الإعفاء الضريبى");

				entity.Property(e => e.Taxes).HasColumnType("money");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrSalaryEmpDtls)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrSalaryEmpDTL_tblEmployees");

				entity.HasOne(d => d.Salary)
					.WithMany(p => p.HrSalaryEmpDtls)
					.HasForeignKey(d => d.SalaryId)
					.HasConstraintName("FK_HrSalaryEmpDTL_HrSalaryHDR");
			});

			modelBuilder.Entity<HrSalaryHdr>(entity =>
			{
				entity.HasKey(e => e.SalaryId);

				entity.ToTable("HrSalaryHDR");

				entity.Property(e => e.SalaryId)
					.ValueGeneratedNever()
					.HasColumnName("SalaryID");

				entity.Property(e => e.Datefrom)
					.HasColumnType("datetime")
					.HasColumnName("datefrom")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Dateto)
					.HasColumnType("datetime")
					.HasColumnName("dateto")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate");

				entity.Property(e => e.FDesc)
					.HasMaxLength(150)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fpost).HasColumnName("fpost");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");
			});

			modelBuilder.Entity<HrSalaryInsHistory>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrSalaryInsHistory");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FPercent).HasColumnName("fPercent");

				entity.Property(e => e.FYear).HasColumnName("fYear");
			});

			modelBuilder.Entity<HrSalaryItem>(entity =>
			{
				entity.HasKey(e => e.ItemId)
					.HasName("PK_hrSalaryItems");

				entity.Property(e => e.ItemId).ValueGeneratedNever();

				entity.Property(e => e.AddLess).HasDefaultValueSql("((1))");

				entity.Property(e => e.CanInsurance)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CanTax)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.DefaultValue).HasColumnType("money");

				entity.Property(e => e.Equation)
					.HasMaxLength(300)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDesc)
					.HasMaxLength(100)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TypyId)
					.HasColumnName("TypyID")
					.HasDefaultValueSql("((1))");

				entity.HasOne(d => d.AddLessNavigation)
					.WithMany(p => p.HrSalaryItems)
					.HasForeignKey(d => d.AddLess)
					.HasConstraintName("FK_HrSalaryItems_HrAddLess");

				entity.HasOne(d => d.Typy)
					.WithMany(p => p.HrSalaryItems)
					.HasForeignKey(d => d.TypyId)
					.HasConstraintName("FK_HrSalaryItems_HrSalaryItemsType");
			});

			modelBuilder.Entity<HrSalaryItemHistory>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrSalaryItemHistory");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.SalaryId).HasColumnName("SalaryID");
			});

			modelBuilder.Entity<HrSalaryItemsGroup>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(512)
					.HasColumnName("fDesc");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA");

				entity.Property(e => e.SalaryItemStr).HasMaxLength(512);
			});

			modelBuilder.Entity<HrSalaryItemsType>(entity =>
			{
				entity.HasKey(e => e.TypeId);

				entity.ToTable("HrSalaryItemsType");

				entity.Property(e => e.TypeId)
					.ValueGeneratedNever()
					.HasColumnName("TypeID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrSalaryType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrSalaryType");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ItemId).HasColumnName("ItemID");
			});

			modelBuilder.Entity<HrSalaryWithCurrency>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrSalaryWithCurrency");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FCatName)
					.HasMaxLength(50)
					.HasColumnName("fCatName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FCount).HasColumnName("fCount");

				entity.Property(e => e.FCurCode).HasColumnName("fCurCode");

				entity.Property(e => e.FValue).HasColumnName("fValue");

				entity.Property(e => e.SalaryId).HasColumnName("SalaryID");
			});

			modelBuilder.Entity<HrSetting>(entity =>
			{
				entity.HasKey(e => e.Code);

				entity.ToTable("HrSetting");

				entity.Property(e => e.Code).ValueGeneratedNever();

				entity.Property(e => e.Added)
					.HasMaxLength(50)
					.HasColumnName("added")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CodeField)
					.HasMaxLength(50)
					.HasColumnName("code_field")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmpId)
					.HasMaxLength(50)
					.HasColumnName("emp_id")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogDate)
					.HasMaxLength(50)
					.HasColumnName("log_date")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogTime)
					.HasMaxLength(50)
					.HasColumnName("log_time")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogType)
					.HasMaxLength(50)
					.HasColumnName("log_type")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogTypeAtt)
					.HasMaxLength(50)
					.HasColumnName("log_type_Att")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogTypeIn)
					.HasMaxLength(50)
					.HasColumnName("log_type_in")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogTypeLeave)
					.HasMaxLength(50)
					.HasColumnName("log_type_Leave")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LogTypeOut)
					.HasMaxLength(50)
					.HasColumnName("log_type_out")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ObjType)
					.HasMaxLength(5)
					.IsUnicode(false)
					.HasColumnName("Obj_Type")
					.HasDefaultValueSql("('Table')")
					.HasComment("Show if Setting in Table or View");

				entity.Property(e => e.StrConnection)
					.HasMaxLength(200)
					.HasColumnName("str_Connection")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TableName)
					.HasMaxLength(50)
					.HasColumnName("table_name")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrStopStartEmp>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrStopStartEmp");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FReason)
					.HasMaxLength(200)
					.HasColumnName("fReason")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FirstState).HasComment("0 - Not First     1 - First State");

				entity.Property(e => e.State).HasComment("0 - Stop      1 - Start");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");
			});

			modelBuilder.Entity<HrStopStartType>(entity =>
			{
				entity.HasKey(e => e.TypeId)
					.HasName("PK_HrEmpStateTypes");

				entity.Property(e => e.TypeId)
					.ValueGeneratedNever()
					.HasColumnName("TypeID");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild1)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild2)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Feild3)
					.HasMaxLength(30)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Notes)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrTaxConst>(entity =>
			{
				entity.HasKey(e => e.FId)
					.HasName("pk_HrTaxConst");

				entity.ToTable("HrTaxConst");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.SlideValue).HasColumnType("money");
			});

			modelBuilder.Entity<HrTrainDtl>(entity =>
			{
				entity.HasKey(e => e.TrainDtlId);

				entity.ToTable("HrTrainDtl");

				entity.Property(e => e.TrainDtlId)
					.ValueGeneratedNever()
					.HasColumnName("trainDtlID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FromDate)
					.HasColumnType("datetime")
					.HasColumnName("fromDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Notes)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Result)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Target)
					.HasMaxLength(50)
					.HasColumnName("target")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ToDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TrainHdrId).HasColumnName("trainHdrID");

				entity.HasOne(d => d.TrainHdr)
					.WithMany(p => p.HrTrainDtls)
					.HasForeignKey(d => d.TrainHdrId)
					.HasConstraintName("FK_HrTrainDtl_HrTrainHdr");
			});

			modelBuilder.Entity<HrTrainHdr>(entity =>
			{
				entity.HasKey(e => e.TrainHdrId);

				entity.ToTable("HrTrainHdr");

				entity.Property(e => e.TrainHdrId)
					.ValueGeneratedNever()
					.HasColumnName("trainHdrID");

				entity.Property(e => e.Description)
					.HasMaxLength(200)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TrainType)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrVacAdd>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVacAdd");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.Dwflinked).HasColumnName("DWFLinked");

				entity.Property(e => e.Dwfstatus).HasColumnName("DWFStatus");

				entity.Property(e => e.DwfstatusDescription)
					.HasMaxLength(50)
					.HasColumnName("DWFStatusDescription")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FCancelDate)
					.HasColumnType("datetime")
					.HasColumnName("fCancelDate")
					.HasComputedColumnSql("(([fdate2]-[Canceled])+(1))", false);

				entity.Property(e => e.FDate1)
					.HasColumnType("datetime")
					.HasColumnName("fDate1")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDate2)
					.HasColumnType("datetime")
					.HasColumnName("fDate2")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDesc)
					.HasMaxLength(100)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.VacId).HasColumnName("VacID");

				entity.Property(e => e.VacNet).HasComment("Net Vac From WeekEnd and Holidays");

				entity.Property(e => e.VacTypeId).HasColumnName("VacTypeID");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrVacAdds)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrVacAdd_tblEmployees");

				entity.HasOne(d => d.Vac)
					.WithMany(p => p.HrVacAdds)
					.HasForeignKey(d => d.VacId)
					.HasConstraintName("FK_HrVacAdd_HrVacHDR");

				entity.HasOne(d => d.VacType)
					.WithMany(p => p.HrVacAdds)
					.HasForeignKey(d => d.VacTypeId)
					.HasConstraintName("FK_HrVacAdd_HrVacType");
			});

			modelBuilder.Entity<HrVacAdm>(entity =>
			{
				entity.HasKey(e => e.Fid)
					.HasName("pk_HrVacAdm");

				entity.ToTable("HrVacAdm");

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrVacCancel>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVacCancel");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(100)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.VacAddId).HasColumnName("VacAddID");

				entity.HasOne(d => d.VacAdd)
					.WithMany(p => p.HrVacCancels)
					.HasForeignKey(d => d.VacAddId)
					.HasConstraintName("FK_HrVacCancel_HrVacAdd");
			});

			modelBuilder.Entity<HrVacCancelDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVacCancelDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.DayDescription).HasComment("1 Begining of day 0 for End of day");

				entity.Property(e => e.VacAddId).HasColumnName("VacAddID");

				entity.Property(e => e.VacDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ValueOfDay).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.VacAdd)
					.WithMany(p => p.HrVacCancelDtls)
					.HasForeignKey(d => d.VacAddId)
					.HasConstraintName("FK_HrVacCancelDtl_HrVacAdd");
			});

			modelBuilder.Entity<HrVacDtl>(entity =>
			{
				entity.HasKey(e => new { e.EmpId, e.VacTypeId, e.VacId });

				entity.ToTable("HrVacDTL");

				entity.Property(e => e.DeportedVac).HasColumnName("deportedVac");

				entity.Property(e => e.DeportedVacOriginal).HasColumnName("deportedVacOriginal");

				entity.Property(e => e.FRemain)
					.HasColumnName("fRemain")
					.HasComputedColumnSql("([VacTypeValue]+[deportedVac])", false);

				entity.Property(e => e.FUsed).HasColumnName("fUsed");

				entity.Property(e => e.VacTypeValueOriginal).HasComment("Basic Vac Value coming");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrVacDtls)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrVacDTL_tblEmployees");

				entity.HasOne(d => d.Vac)
					.WithMany(p => p.HrVacDtls)
					.HasForeignKey(d => d.VacId)
					.HasConstraintName("FK_HrVacDTL_HrVacHDR");

				entity.HasOne(d => d.VacType)
					.WithMany(p => p.HrVacDtls)
					.HasForeignKey(d => d.VacTypeId)
					.HasConstraintName("FK_HrVacDTL_HrVacType");
			});

			modelBuilder.Entity<HrVacHdr>(entity =>
			{
				entity.HasKey(e => e.VacId);

				entity.ToTable("HrVacHDR");

				entity.Property(e => e.VacId)
					.ValueGeneratedNever()
					.HasColumnName("VacID");

				entity.Property(e => e.Deported)
					.HasColumnName("deported")
					.HasComment("if deported values done or not");

				entity.Property(e => e.FDate1)
					.HasColumnType("datetime")
					.HasColumnName("fDate1")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDate2)
					.HasColumnType("datetime")
					.HasColumnName("fDate2")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FDesc)
					.HasMaxLength(150)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fpost).HasColumnName("fpost");
			});

			modelBuilder.Entity<HrVacReplace>(entity =>
			{
				entity.HasKey(e => e.Fid);

				entity.ToTable("HrVacReplace");

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.ReplacedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Emp)
					.WithMany(p => p.HrVacReplaces)
					.HasForeignKey(d => d.EmpId)
					.HasConstraintName("FK_HrVacReplace_tblEmployees");
			});

			modelBuilder.Entity<HrVacType>(entity =>
			{
				entity.HasKey(e => e.Fid)
					.HasName("PK_hrvactype");

				entity.ToTable("HrVacType");

				entity.Property(e => e.Fid)
					.ValueGeneratedNever()
					.HasColumnName("fid");

				entity.Property(e => e.Canmoved).HasColumnName("canmoved");

				entity.Property(e => e.Canreplaced).HasColumnName("canreplaced");

				entity.Property(e => e.DefaultValue)
					.HasColumnName("defaultValue")
					.HasDefaultValueSql("((10))");

				entity.Property(e => e.Description)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("description")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Fname)
					.HasMaxLength(50)
					.HasColumnName("fname")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FnameA)
					.HasMaxLength(50)
					.HasColumnName("fnameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SalaryPaid)
					.IsRequired()
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<HrVacationSpecificDtl>(entity =>
			{
				entity.HasKey(e => e.DtlId);

				entity.ToTable("HrVacationSpecificDtl");

				entity.Property(e => e.DtlId).HasColumnName("DtlID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.HdrId).HasColumnName("HdrID");

				entity.HasOne(d => d.Hdr)
					.WithMany(p => p.HrVacationSpecificDtls)
					.HasForeignKey(d => d.HdrId)
					.HasConstraintName("FK_HrVacationSpecificDtl_HrVacationSpecificHdr");
			});

			modelBuilder.Entity<HrVacationSpecificHdr>(entity =>
			{
				entity.HasKey(e => e.HdrId);

				entity.ToTable("HrVacationSpecificHdr");

				entity.Property(e => e.HdrId)
					.ValueGeneratedNever()
					.HasColumnName("HdrID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPosted).HasColumnName("fPosted");

				entity.Property(e => e.SalaryItems)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')")
					.HasComment("item id,item id,.....");

				entity.Property(e => e.VacTypeId).HasColumnName("VacTypeID");
			});

			modelBuilder.Entity<HrVisa>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVisa");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FPermanent).HasColumnName("fPermanent");

				entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

				entity.Property(e => e.VisaNo)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrVisaDtl>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVisaDtl");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.Fcount).HasColumnName("FCount");

				entity.Property(e => e.JobId).HasColumnName("JobID");

				entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

				entity.Property(e => e.PointOfArrTravel)
					.HasMaxLength(255)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Hdr)
					.WithMany(p => p.HrVisaDtls)
					.HasForeignKey(d => d.HdrId)
					.HasConstraintName("FK_HrVisaDtl_HrVisa");
			});

			modelBuilder.Entity<HrVisaReNew>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HrVisaReNew");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.NewDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.OldDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.VisaNoId).HasColumnName("VisaNoID");
			});

			modelBuilder.Entity<HrVisaType>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.FDesc)
					.HasMaxLength(50)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HrWeekEnd>(entity =>
			{
				entity.HasKey(e => e.FYear);

				entity.ToTable("HrWeekEnd");

				entity.Property(e => e.FYear)
					.ValueGeneratedNever()
					.HasColumnName("fYear");
			});

			modelBuilder.Entity<HrWriteSalary>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HrWriteSalary");

				entity.Property(e => e.FAbsence).HasColumnName("fAbsence");

				entity.Property(e => e.FAbsenceDisc).HasColumnName("fAbsenceDisc");

				entity.Property(e => e.FBonus).HasColumnName("fBonus");

				entity.Property(e => e.FDate)
					.HasMaxLength(7)
					.HasColumnName("fDate");

				entity.Property(e => e.FDeleted).HasColumnName("fDeleted");

				entity.Property(e => e.FDiscount).HasColumnName("fDiscount");

				entity.Property(e => e.FEmpId).HasColumnName("fEmpID");

				entity.Property(e => e.FHours).HasColumnName("fHours");

				entity.Property(e => e.FIns).HasColumnName("fIns");

				entity.Property(e => e.FMoreHours).HasColumnName("fMoreHours");

				entity.Property(e => e.FMoreMoney).HasColumnName("fMoreMoney");

				entity.Property(e => e.FNet).HasColumnName("fNet");

				entity.Property(e => e.FPormotion).HasColumnName("fPormotion");

				entity.Property(e => e.FSalary).HasColumnName("fSalary");

				entity.Property(e => e.FTax).HasColumnName("fTax");
			});

			modelBuilder.Entity<HrYearHoliday>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.DayDesc).HasMaxLength(255);

				entity.Property(e => e.FromDate).HasColumnType("datetime");

				entity.Property(e => e.ToDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<HrattendanceGroup>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HRAttendanceGroups");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.MainEmpId).HasColumnName("MainEmpID");

				entity.Property(e => e.SubEmpId).HasColumnName("SubEmpID");
			});

			modelBuilder.Entity<HrattendanceGroupsAttend>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HRAttendanceGroupsAttend");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainEmpId).HasColumnName("MainEmpID");

				entity.Property(e => e.SubEmpId).HasColumnName("SubEmpID");
			});

			modelBuilder.Entity<HrattendancePlanDtl>(entity =>
			{
				entity.HasKey(e => e.AttPlanDtlId);

				entity.ToTable("HRAttendancePlanDTL");

				entity.Property(e => e.AttPlanDtlId)
					.ValueGeneratedNever()
					.HasColumnName("AttPlanDTL_Id");

				entity.Property(e => e.AttPlanDtlDelayTime)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_DelayTime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlDesc)
					.HasMaxLength(300)
					.HasColumnName("AttPlanDTL_Desc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlFromHour)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_FromHour")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlFromHour1)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_FromHour1")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlGroupId).HasColumnName("AttPlanDTL_GroupId");

				entity.Property(e => e.AttPlanDtlHdrid).HasColumnName("AttPlanDTL_HDRId");

				entity.Property(e => e.AttPlanDtlOverTime)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_OverTime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlToHour)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_ToHour")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlToHour1)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_ToHour1")
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.AttPlanDtlHdr)
					.WithMany(p => p.HrattendancePlanDtls)
					.HasForeignKey(d => d.AttPlanDtlHdrid)
					.HasConstraintName("FK_HRAttendancePlanDTL_HRAttendancePlanHDR");
			});

			modelBuilder.Entity<HrattendancePlanEmp>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HRAttendancePlanEmp");

				entity.Property(e => e.FId).HasColumnName("fID");

				entity.Property(e => e.AttPlanDtlFromHour)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_FromHour")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlFromHour1)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_FromHour1")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlToHour)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_ToHour")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AttPlanDtlToHour1)
					.HasMaxLength(50)
					.HasColumnName("AttPlanDTL_ToHour1")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Attend)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.GroupId).HasColumnName("GroupID");
			});

			modelBuilder.Entity<HrattendancePlanHdr>(entity =>
			{
				entity.HasKey(e => e.AttPlanHdrId);

				entity.ToTable("HRAttendancePlanHDR");

				entity.Property(e => e.AttPlanHdrId)
					.ValueGeneratedNever()
					.HasColumnName("AttPlanHDR_Id");

				entity.Property(e => e.AttPlanHdrCode)
					.HasMaxLength(50)
					.HasColumnName("AttPlanHDR_Code");

				entity.Property(e => e.AttPlanHdrDesc)
					.HasMaxLength(1000)
					.HasColumnName("AttPlanHDR_Desc");

				entity.Property(e => e.AttPlanHdrFromDate)
					.HasColumnType("datetime")
					.HasColumnName("AttPlanHDR_FromDate");

				entity.Property(e => e.AttPlanHdrToDate)
					.HasColumnType("datetime")
					.HasColumnName("AttPlanHDR_ToDate");

				entity.Property(e => e.FPost).HasColumnName("fPost");

				entity.Property(e => e.OptionId).HasColumnName("OptionID");
			});

			modelBuilder.Entity<HrdayVacation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HRDayVacation");
			});

			modelBuilder.Entity<HrdaysName>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HRDaysName");

				entity.Property(e => e.DayName).HasMaxLength(50);

				entity.Property(e => e.DayNameA).HasMaxLength(50);
			});

			modelBuilder.Entity<HrempGroup>(entity =>
			{
				entity.HasKey(e => new { e.GroupId, e.EmpId });

				entity.ToTable("HREmpGroup");
			});

			modelBuilder.Entity<HrempGroupHist>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HREmpGroupHist");

				entity.Property(e => e.EmpId).HasColumnName("EmpID");

				entity.Property(e => e.FDate)
					.HasColumnType("datetime")
					.HasColumnName("fDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FType)
					.HasColumnName("fType")
					.HasComment("0 trans from 1 trans To");

				entity.Property(e => e.GroupId).HasColumnName("GroupID");
			});

			modelBuilder.Entity<Hrgroup>(entity =>
			{
				entity.HasKey(e => e.FId);

				entity.ToTable("HRGroups");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.ApplyRules)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FDesc)
					.HasMaxLength(300)
					.HasColumnName("fDesc")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(100)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(100)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<HryearVacationDtl>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HRYearVacationDTL");

				entity.Property(e => e.HryearVacDtlDaysNumber)
					.HasMaxLength(50)
					.HasColumnName("HRYearVacDTL_DaysNumber");

				entity.Property(e => e.HryearVacDtlFromDate)
					.HasColumnType("datetime")
					.HasColumnName("HRYearVacDTL_FromDate");

				entity.Property(e => e.HryearVacDtlHdrid).HasColumnName("HRYearVacDTL_HDRId");

				entity.Property(e => e.HryearVacDtlId).HasColumnName("HRYearVacDTL_Id");

				entity.Property(e => e.HryearVacDtlToDate)
					.HasColumnType("datetime")
					.HasColumnName("HRYearVacDTL_ToDate");

				entity.Property(e => e.HryearVacDtlVacName)
					.HasMaxLength(50)
					.HasColumnName("HRYearVacDTL_VacName");

				entity.Property(e => e.HryearVacDtlVacNameA)
					.HasMaxLength(50)
					.HasColumnName("HRYearVacDTL_VacNameA");
			});

			modelBuilder.Entity<HryearVacationHdr>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("HRYearVacationHDR");

				entity.Property(e => e.HryearVacHdrDesc)
					.HasMaxLength(1000)
					.HasColumnName("HRYearVacHDR_Desc");

				entity.Property(e => e.HryearVacHdrId).HasColumnName("HRYearVacHDR_Id");

				entity.Property(e => e.HryearVacHdrYear)
					.HasMaxLength(50)
					.HasColumnName("HRYearVacHDR_Year");
			});

			modelBuilder.Entity<JournalDtl>(entity =>
			{
				entity.HasKey(e => new { e.Id, e.JournalId });

				entity.ToTable("JournalDtl");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.AccountActivityId).HasColumnName("AccountActivityID");

				entity.Property(e => e.AccountAnalysisId).HasColumnName("AccountAnalysisID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

				entity.Property(e => e.CurrencyRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ForeignCredit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ForeignDebit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.JournalNotesAr).HasDefaultValueSql("('')");

				entity.Property(e => e.JournalNotesEn).HasDefaultValueSql("('')");

				entity.Property(e => e.LocalCredit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.LocalDebit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TransactionDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.HasMany(d => d.CostCenters)
					.WithMany(p => p.Journals)
					.UsingEntity<Dictionary<string, object>>(
						"JournalDtlCostCenter",
						l => l.HasOne<CostCenter>().WithMany().HasForeignKey("CostCenterId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__JournalDt__CostC__70204077"),
						r => r.HasOne<JournalDtl>().WithMany().HasForeignKey("JournalDtlId", "JournalId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__JournalDtlCostCe__711464B0"),
						j =>
						{
							j.HasKey("JournalDtlId", "CostCenterId", "JournalId").HasName("PK__JournalD__92CCDD57C2026276");

							j.ToTable("JournalDtlCostCenter");
						});
			});

			modelBuilder.Entity<JournalHdr>(entity =>
			{
				entity.ToTable("JournalHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.JournalNotesAr).HasDefaultValueSql("('')");

				entity.Property(e => e.JournalNotesEn).HasDefaultValueSql("('')");

				entity.Property(e => e.JournalTypeId).HasColumnName("JournalTypeID");

				entity.Property(e => e.ManualId).HasColumnName("ManualID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TotalCredit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TotalDebit).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TransactionDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

				entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

				entity.Property(e => e.UserManualId)
					.HasMaxLength(50)
					.HasColumnName("UserManualID")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<JournalTransactionType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<JournalType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

				entity.HasOne(d => d.LocationType)
					.WithMany(p => p.Locations)
					.HasForeignKey(d => d.LocationTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Locations_LocationTypes");

				entity.HasOne(d => d.Warehouse)
					.WithMany(p => p.Locations)
					.HasForeignKey(d => d.WarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Locations_Warehouses");
			});

			modelBuilder.Entity<LocationType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<ManufacturingCostType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<MeasurementUnit>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ProductUnitPriceId).HasColumnName("ProductUnitPriceID");
			});

			modelBuilder.Entity<Menu>(entity =>
			{
				entity.ToTable("Menu");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PageUrl)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<ModuleAccountsDtl>(entity =>
			{
				entity.HasKey(e => new { e.Id, e.ModuleAccountsHdrId })
					.HasName("PK_ModuleAccountsDtl_1");

				entity.ToTable("ModuleAccountsDtl");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ModuleAccountsHdrId).HasColumnName("ModuleAccountsHdrID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<ModuleAccountsHdr>(entity =>
			{
				entity.ToTable("ModuleAccountsHdr");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.JournalTypeId).HasColumnName("JournalTypeID");
			});

			modelBuilder.Entity<OfferReason>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<OfferType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Pathe>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<PaymentType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Product>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ManufacturingCountryId).HasColumnName("ManufacturingCountryID");

				entity.Property(e => e.MaxReorderPoint).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.MeasurementUnitId).HasColumnName("MeasurementUnitID");

				entity.Property(e => e.Photo)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

				entity.Property(e => e.ProductHeight).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductProductionTypeId).HasColumnName("ProductProductionTypeID");

				entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

				entity.Property(e => e.ProductUnitPriceId).HasColumnName("ProductUnitPriceID");

				entity.Property(e => e.ProductWidth).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ReorderPoint).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.SafetyPoint).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

				entity.Property(e => e.SupplierProductId)
					.HasMaxLength(50)
					.HasColumnName("SupplierProductID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Vatpercentage)
					.HasColumnType("decimal(19, 4)")
					.HasColumnName("VATPercentage");

				entity.Property(e => e.VattypeId).HasColumnName("VATTypeID");

				entity.HasOne(d => d.MeasurementUnit)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.MeasurementUnitId)
					.HasConstraintName("FK_Products_MeasurementUnits");

				entity.HasOne(d => d.ProductGroup)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.ProductGroupId)
					.HasConstraintName("FK_Products_ProductGroups");

				entity.HasOne(d => d.ProductProductionType)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.ProductProductionTypeId)
					.HasConstraintName("FK_Products_ProductProductionTypes");

				entity.HasOne(d => d.ProductType)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.ProductTypeId)
					.HasConstraintName("FK_Products_ProductTypes");

				entity.HasOne(d => d.ProductUnitPrice)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.ProductUnitPriceId)
					.HasConstraintName("ProductUnitPriceID");

				entity.HasOne(d => d.Vattype)
					.WithMany(p => p.Products)
					.HasForeignKey(d => d.VattypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Products_VATTypes");
			});

			modelBuilder.Entity<ProductGroup>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ParentId).HasColumnName("ParentID");
			});

			modelBuilder.Entity<ProductProductionType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<ProductProperty>(entity =>
			{
				entity.HasKey(e => e.ProductPropertiesId)
					.HasName("PK__ProductP__9CB741EFFC759C44");

				entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

				entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.ProductHeight).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductWidth).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.ProductProperties)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK__ProductPr__Produ__7DAF45BF");
			});

			modelBuilder.Entity<ProductSetting>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ProductLength)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<ProductType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<ProductUnitPrice>(entity =>
			{
				entity.Property(e => e.HalfWholesalePrice).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.MeasurementUnitId).HasColumnName("MeasurementUnitID");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.WholesalePrice).HasColumnType("decimal(18, 2)");

				entity.HasOne(d => d.MeasurementUnit)
					.WithMany(p => p.ProductUnitPrices)
					.HasForeignKey(d => d.MeasurementUnitId)
					.HasConstraintName("FK__ProductUn__Measu__79DEB4DB");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.ProductUnitPrices)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK__ProductUn__Produ__78EA90A2");
			});

			modelBuilder.Entity<ProductsCost>(entity =>
			{
				entity.ToTable("ProductsCost");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CostRate).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<ProductsPurchasePrice>(entity =>
			{
				entity.ToTable("ProductsPurchasePrice");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<ProductsQuantity>(entity =>
			{
				entity.ToTable("ProductsQuantity");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<PurchaseInvoiceDtl>(entity =>
			{
				entity.ToTable("PurchaseInvoiceDtl");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.NetValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.PurchaseInvoiceHdrId).HasColumnName("PurchaseInvoiceHdrID");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ReturnedQuantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TotalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.VatValue).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.PurchaseInvoiceDtls)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK_PurchaseInvoiceDtl_Products");

				entity.HasOne(d => d.PurchaseInvoiceHdr)
					.WithMany(p => p.PurchaseInvoiceDtls)
					.HasForeignKey(d => d.PurchaseInvoiceHdrId)
					.HasConstraintName("FK_PurchaseInvoiceDtl_PurchaseInvoiceHdr");
			});

			modelBuilder.Entity<PurchaseInvoiceHdr>(entity =>
			{
				entity.ToTable("PurchaseInvoiceHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CashBoxId).HasColumnName("CashBoxID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.InvoiceDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.InvoiceDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.InvoiceValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.NetValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.OriginalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PaidValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PurchaseInvoiceId).HasColumnName("PurchaseInvoiceID");

				entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

				entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

				entity.Property(e => e.SupplierInvoiceId)
					.HasMaxLength(100)
					.HasColumnName("SupplierInvoiceID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.VatValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<PurchaseOrderDtl>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("PurchaseOrderDtl");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.OrderId)
					.HasColumnName("OrderID")
					.HasComment("");

				entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Quantity)
					.HasColumnType("decimal(19, 4)")
					.HasComment("");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.HasOne(d => d.Order)
					.WithMany()
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_PurchaseOrderDTL_PurchaseOrderHDR");
			});

			modelBuilder.Entity<PurchaseOrderHdr>(entity =>
			{
				entity.HasKey(e => e.OrderId)
					.HasName("PK_PurchaseOrderHDR");

				entity.ToTable("PurchaseOrderHdr");

				entity.Property(e => e.OrderId)
					.ValueGeneratedNever()
					.HasColumnName("OrderID")
					.HasComment("Order ID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OrderDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OrderDescription)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.RequestId).HasColumnName("RequestID");

				entity.Property(e => e.StatusId)
					.HasColumnName("StatusID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SupplierId)
					.HasColumnName("SupplierID")
					.HasComment("Supplier ID");
			});

			modelBuilder.Entity<PurchaseOrderStatus>(entity =>
			{
				entity.ToTable("PurchaseOrderStatus");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<PurchaseRequestDtl>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("PurchaseRequestDtl");

				entity.Property(e => e.AppovedQuantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Id).ValueGeneratedOnAdd();

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Quantity)
					.HasColumnType("decimal(19, 4)")
					.HasComment("qunatity requiered in request");

				entity.Property(e => e.RequestId)
					.HasColumnName("RequestID")
					.HasComment("id of item of Request");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.HasOne(d => d.Request)
					.WithMany()
					.HasForeignKey(d => d.RequestId)
					.HasConstraintName("FK_PurchaseRequestDtl_PurchaseRequestHdr");
			});

			modelBuilder.Entity<PurchaseRequestHdr>(entity =>
			{
				entity.HasKey(e => e.RequestId)
					.HasName("PK_PurchaseRequestHDR");

				entity.ToTable("PurchaseRequestHdr");

				entity.Property(e => e.RequestId)
					.ValueGeneratedNever()
					.HasColumnName("RequestID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DepartmentId)
					.HasColumnName("DepartmentID")
					.HasComment("ID of department that want the Request");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.RequestDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.RequestDescription)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.StatusId).HasColumnName("StatusID");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.HasOne(d => d.Status)
					.WithMany(p => p.PurchaseRequestHdrs)
					.HasForeignKey(d => d.StatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PurchaseRequestHdr_PurchaseRequestStatus");

				entity.HasOne(d => d.Type)
					.WithMany(p => p.PurchaseRequestHdrs)
					.HasForeignKey(d => d.TypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PurchaseRequestHdr_PurchaseRequestTypes");
			});

			modelBuilder.Entity<PurchaseRequestStatus>(entity =>
			{
				entity.ToTable("PurchaseRequestStatus");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<PurchaseRequestType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<PurchaseReturnDtl>(entity =>
			{
				entity.ToTable("PurchaseReturnDtl");

				entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.PurchaseReturnHdrId).HasColumnName("PurchaseReturnHdrID");

				entity.Property(e => e.ReturnedQuantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.PurchaseReturnDtls)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK_PurchaseReturnDtl_Products");

				entity.HasOne(d => d.PurchaseInvoiceDtl)
					.WithMany(p => p.PurchaseReturnDtls)
					.HasForeignKey(d => d.PurchaseInvoiceDtlId)
					.HasConstraintName("PurchaseInvoiceDtlId");

				entity.HasOne(d => d.PurchaseReturnHdr)
					.WithMany(p => p.PurchaseReturnDtls)
					.HasForeignKey(d => d.PurchaseReturnHdrId)
					.HasConstraintName("FK_PurchaseReturnDtl_PurchaseReturnHdr");
			});

			modelBuilder.Entity<PurchaseReturnHdr>(entity =>
			{
				entity.ToTable("PurchaseReturnHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CashBoxId).HasColumnName("CashBoxID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.NetValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.OriginalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PurchaseInvoiceHdrId).HasColumnName("PurchaseInvoiceHdrID");

				entity.Property(e => e.PurchaseReturnId).HasColumnName("PurchaseReturnID");

				entity.Property(e => e.ReturnDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ReturnDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ReturnValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.VatValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<ReceiptType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<SalesCashType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

				entity.Property(e => e.CommissionAccountId).HasColumnName("CommissionAccountID");

				entity.Property(e => e.CommissionPercent).HasColumnType("decimal(6, 4)");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.VatAccountId).HasColumnName("VatAccountID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(6, 4)");
			});

			modelBuilder.Entity<SalesInvoiceDtl>(entity =>
			{
				entity.ToTable("SalesInvoiceDtl");

				entity.Property(e => e.Cost).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.NetValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ReturnedQuantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.SalesInvoiceHdrId).HasColumnName("SalesInvoiceHdrID");

				entity.Property(e => e.TotalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.VatValue).HasColumnType("decimal(19, 4)");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.SalesInvoiceDtls)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK_SalesInvoiceDtl_Products");

				entity.HasOne(d => d.SalesInvoiceHdr)
					.WithMany(p => p.SalesInvoiceDtls)
					.HasForeignKey(d => d.SalesInvoiceHdrId)
					.HasConstraintName("FK_SalesInvoiceDtl_SalesInvoiceHdr");
			});

			modelBuilder.Entity<SalesInvoiceHdr>(entity =>
			{
				entity.ToTable("SalesInvoiceHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.GroupOfferId).HasColumnName("GroupOfferID");

				entity.Property(e => e.InvoiceDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.InvoiceDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.InvoiceValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ItemOfferId).HasColumnName("ItemOfferID");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.LocationId).HasColumnName("LocationID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.NetValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.OriginalValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PaidValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.SalesCashTypeId).HasColumnName("SalesCashTypeID");

				entity.Property(e => e.SalesInvoiceId).HasColumnName("SalesInvoiceID");

				entity.Property(e => e.SpecialOfferId).HasColumnName("SpecialOfferID");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");

				entity.Property(e => e.VatPercent).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.VatValue).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
			});

			modelBuilder.Entity<SalesReturnReason>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<Salesman>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.AreaId).HasColumnName("AreaID");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FaxNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MobileNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PathId).HasColumnName("PathID");

				entity.Property(e => e.Percentage).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.TelephoneNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Area)
					.WithMany(p => p.Salesmen)
					.HasForeignKey(d => d.AreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Salesmen_Areas");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Salesmen)
					.HasForeignKey(d => d.CityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Salesmen_Cities");

				entity.HasOne(d => d.Employee)
					.WithMany(p => p.Salesmen)
					.HasForeignKey(d => d.EmployeeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Salesmen_Employees");

				entity.HasOne(d => d.Path)
					.WithMany(p => p.Salesmen)
					.HasForeignKey(d => d.PathId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Salesmen_Pathes");
			});

			modelBuilder.Entity<Section>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

				entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.Sections)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_Sections_Departments");
			});

			modelBuilder.Entity<Shelf>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Division)
					.WithMany(p => p.Shelves)
					.HasForeignKey(d => d.DivisionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Shelves_Divisions");
			});

			modelBuilder.Entity<ShippingType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<State>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CountryId).HasColumnName("CountryID");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Country)
					.WithMany(p => p.States)
					.HasForeignKey(d => d.CountryId)
					.HasConstraintName("FK_States_Countries");
			});

			modelBuilder.Entity<Supplier>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

				entity.Property(e => e.ArabicAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ChargePersonArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ChargePersonEmail)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ChargePersonEnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ChargePersonJob)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ChargePersonMobile)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CityId).HasColumnName("CityID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishAddress)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FaxNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MobileNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ShippingTypeId).HasColumnName("ShippingTypeID");

				entity.Property(e => e.SupplierActivityId).HasColumnName("SupplierActivityID");

				entity.Property(e => e.SupplierGroupId).HasColumnName("SupplierGroupID");

				entity.Property(e => e.SupplierTypeId).HasColumnName("SupplierTypeID");

				entity.Property(e => e.TelephoneNo)
					.HasMaxLength(15)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Website)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_Accounts");

				entity.HasOne(d => d.City)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.CityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_Cities");

				entity.HasOne(d => d.ShippingType)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.ShippingTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_ShippingTypes");

				entity.HasOne(d => d.SupplierActivity)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.SupplierActivityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_SupplierActivities");

				entity.HasOne(d => d.SupplierGroup)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.SupplierGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_SupplierGroups");

				entity.HasOne(d => d.SupplierType)
					.WithMany(p => p.Suppliers)
					.HasForeignKey(d => d.SupplierTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Suppliers_SupplierTypes");
			});

			modelBuilder.Entity<SupplierActivity>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<SupplierGroup>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainAccountId).HasColumnName("MainAccountID");
			});

			modelBuilder.Entity<SupplierType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainAccountId).HasColumnName("MainAccountID");
			});

			modelBuilder.Entity<SystemTranslation>(entity =>
			{
				entity.ToTable("SystemTranslation");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ColumnName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ControlName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<TblEmployee>(entity =>
			{
				entity.HasKey(e => e.FId)
					.IsClustered(false);

				entity.ToTable("tblEmployees");

				entity.Property(e => e.FId)
					.ValueGeneratedNever()
					.HasColumnName("fID");

				entity.Property(e => e.BloodType)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BoundId).HasColumnName("BoundID");

				entity.Property(e => e.CanInsurance)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CanTax)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CardNo)
					.HasMaxLength(50)
					.HasColumnName("CardNO")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ContractEnd)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DepartmentId)
					.HasColumnName("DepartmentID")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Experience)
					.HasMaxLength(150)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FAcountNo)
					.HasMaxLength(1024)
					.HasColumnName("fAcountNo")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FAddress)
					.HasMaxLength(80)
					.HasColumnName("fAddress")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FAddress2)
					.HasMaxLength(80)
					.HasColumnName("fAddress2")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FBank)
					.HasMaxLength(50)
					.HasColumnName("fBank")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FBirth)
					.HasColumnType("datetime")
					.HasColumnName("fBirth");

				entity.Property(e => e.FBranchId).HasColumnName("fBranchID");

				entity.Property(e => e.FCustomerService).HasColumnName("fCustomerService");

				entity.Property(e => e.FDeleted)
					.HasColumnName("fDeleted")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FDescription)
					.HasMaxLength(120)
					.HasColumnName("fDescription")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FDisc)
					.HasColumnType("money")
					.HasColumnName("fDisc")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FEmail)
					.HasMaxLength(50)
					.HasColumnName("fEmail")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FEmpType).HasColumnName("fEmpType");

				entity.Property(e => e.FGender)
					.HasColumnName("fGender")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FGross)
					.HasColumnType("money")
					.HasColumnName("fGross")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FHiring)
					.HasColumnType("datetime")
					.HasColumnName("fHiring");

				entity.Property(e => e.FIdno)
					.HasMaxLength(25)
					.HasColumnName("fIDNo");

				entity.Property(e => e.FJob)
					.HasMaxLength(50)
					.HasColumnName("fJob")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FJobEn)
					.HasMaxLength(50)
					.HasColumnName("fJobEn")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FName)
					.HasMaxLength(50)
					.HasColumnName("fName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNameA)
					.HasMaxLength(50)
					.HasColumnName("fNameA")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FNet)
					.HasColumnType("money")
					.HasColumnName("fNet")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FPathId).HasColumnName("fPathID");

				entity.Property(e => e.FPaymentType)
					.HasColumnName("fPaymentType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FPlayer).HasColumnName("fPlayer");

				entity.Property(e => e.FRepDate)
					.HasColumnType("datetime")
					.HasColumnName("fRepDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FReplicated)
					.HasColumnName("fReplicated")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FShiftId)
					.HasColumnName("fShiftID")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FSrvcPro)
					.IsRequired()
					.HasColumnName("fSrvcPro")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.FStatus).HasColumnName("fStatus");

				entity.Property(e => e.FTax)
					.HasColumnType("money")
					.HasColumnName("fTax")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FTelephone)
					.HasMaxLength(20)
					.HasColumnName("fTelephone")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FTelephone2)
					.HasMaxLength(20)
					.HasColumnName("fTelephone2")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.FTelephone3)
					.HasMaxLength(20)
					.HasColumnName("fTelephone3")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Graduation)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.HiringRenew)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.IdIssuer)
					.HasMaxLength(50)
					.HasColumnName("ID_Issuer")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Idend)
					.HasColumnType("datetime")
					.HasColumnName("IDEnd")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Idrelease)
					.HasColumnType("datetime")
					.HasColumnName("IDRelease")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.InsuranceNo)
					.HasMaxLength(12)
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.InsuranceSalary).HasColumnType("money");

				entity.Property(e => e.InsuranceShareVal).HasComment("Value of Insurance payed Share for Emp");

				entity.Property(e => e.IqamaDate1)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.IqamaDate2)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.IqamaId)
					.HasMaxLength(50)
					.HasColumnName("IqamaID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IsuranceDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.JobId).HasColumnName("JobID");

				entity.Property(e => e.MachineId)
					.HasMaxLength(50)
					.HasColumnName("MachineID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MartialStatusId).HasColumnName("MartialStatusID");

				entity.Property(e => e.MilitryDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

				entity.Property(e => e.NominationTypeId).HasColumnName("NominationTypeID");

				entity.Property(e => e.PassportDate1)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PassportDate2)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PassportId)
					.HasMaxLength(50)
					.HasColumnName("PassportID")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PassportIssue)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PreventInsReason)
					.HasMaxLength(155)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Qualification)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

				entity.Property(e => e.SIqamaDate1)
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasColumnName("sIqamaDate1")
					.HasComputedColumnSql("(CONVERT([char](10),[IqamaDate1],(131)))", false)
					.IsFixedLength();

				entity.Property(e => e.SIqamaDate2)
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasColumnName("sIqamaDate2")
					.HasComputedColumnSql("(CONVERT([char](10),[IqamaDate2],(131)))", false)
					.IsFixedLength();

				entity.Property(e => e.SectionId).HasColumnName("SectionID");

				entity.Property(e => e.SubEmpId).HasColumnName("SubEmpID");

				entity.Property(e => e.UniFormSize)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.UniformColor)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.UniformType)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.WeekendId).HasColumnName("WeekendID");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.TblEmployees)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_tblEmployees_HrDepartment");
			});

			modelBuilder.Entity<TransactionInDtl>(entity =>
			{
				entity.HasKey(e => new { e.TransactionInHdrId, e.ProductId });

				entity.ToTable("TransactionInDtl");

				entity.Property(e => e.TransactionInHdrId).HasColumnName("TransactionInHdrID");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Cost).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.TransactionInDtls)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK_TransactionInDtl_Products");

				entity.HasOne(d => d.TransactionInHdr)
					.WithMany(p => p.TransactionInDtls)
					.HasForeignKey(d => d.TransactionInHdrId)
					.HasConstraintName("FK_TransactionInDtl_TransactionInHdr");
			});

			modelBuilder.Entity<TransactionInHdr>(entity =>
			{
				entity.ToTable("TransactionInHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.InBranchId).HasColumnName("InBranchID");

				entity.Property(e => e.InLocationId).HasColumnName("InLocationID");

				entity.Property(e => e.InWarehouseId).HasColumnName("InWarehouseID");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OutBranchId).HasColumnName("OutBranchID");

				entity.Property(e => e.OutLocationId).HasColumnName("OutLocationID");

				entity.Property(e => e.OutWarehouseId).HasColumnName("OutWarehouseID");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TransactionDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TransactionDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

				entity.Property(e => e.TransferId).HasColumnName("TransferID");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");
			});

			modelBuilder.Entity<TransactionInType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<TransactionOutDtl>(entity =>
			{
				entity.HasKey(e => new { e.TransactionOutHdrId, e.ProductId });

				entity.ToTable("TransactionOutDtl");

				entity.Property(e => e.TransactionOutHdrId).HasColumnName("TransactionOutHdrID");

				entity.Property(e => e.ProductId).HasColumnName("ProductID");

				entity.Property(e => e.Cost).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.ProductDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

				entity.Property(e => e.UnitId).HasColumnName("UnitID");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.TransactionOutDtls)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK_TransactionOutDtl_Products");

				entity.HasOne(d => d.TransactionOutHdr)
					.WithMany(p => p.TransactionOutDtls)
					.HasForeignKey(d => d.TransactionOutHdrId)
					.HasConstraintName("FK_TransactionOutDtl_TransactionOutHdr");
			});

			modelBuilder.Entity<TransactionOutHdr>(entity =>
			{
				entity.ToTable("TransactionOutHdr");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("ID");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.InBranchId).HasColumnName("InBranchID");

				entity.Property(e => e.JournalId).HasColumnName("JournalID");

				entity.Property(e => e.ModifiedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OutBranchId).HasColumnName("OutBranchID");

				entity.Property(e => e.OutLocationId).HasColumnName("OutLocationID");

				entity.Property(e => e.OutWarehouseId).HasColumnName("OutWarehouseID");

				entity.Property(e => e.PostedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TransactionDate)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TransactionDescription)
					.HasMaxLength(4000)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

				entity.Property(e => e.TypeId).HasColumnName("TypeID");
			});

			modelBuilder.Entity<TransactionOutType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CommissionPercent).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

				entity.Property(e => e.Password)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PrepaidPercent).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.PrepaidValue).HasColumnType("decimal(18, 2)");

				entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

				entity.Property(e => e.Username)
					.HasMaxLength(50)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Users)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_Users_Branches");

				entity.HasOne(d => d.Employee)
					.WithMany(p => p.Users)
					.HasForeignKey(d => d.EmployeeId)
					.HasConstraintName("FK_Users_Employees");

				entity.HasOne(d => d.UserGroup)
					.WithMany(p => p.Users)
					.HasForeignKey(d => d.UserGroupId)
					.HasConstraintName("FK_Users_UserGroups");
			});

			modelBuilder.Entity<UserBankAccount>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BanckAccountId).HasColumnName("BanckAccountID");

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.BanckAccount)
					.WithMany(p => p.UserBankAccounts)
					.HasForeignKey(d => d.BanckAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserBankAccounts_BankAccounts");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserBankAccounts)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_UserBankAccounts_Users");
			});

			modelBuilder.Entity<UserBranch>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.UserBranches)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserBranches_Branches");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserBranches)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserBranches_Users");
			});

			modelBuilder.Entity<UserCashBox>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.CashBoxId).HasColumnName("CashBoxID");

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.CashBox)
					.WithMany(p => p.UserCashBoxes)
					.HasForeignKey(d => d.CashBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCashBoxes_CashBoxes");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserCashBoxes)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_UserCashBoxes_Users");
			});

			modelBuilder.Entity<UserGroup>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<UserGroupPermission>(entity =>
			{
				entity.ToTable("UserGroupPermission");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.MenuId).HasColumnName("MenuID");

				entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

				entity.HasOne(d => d.Menu)
					.WithMany(p => p.UserGroupPermissions)
					.HasForeignKey(d => d.MenuId)
					.HasConstraintName("FK_UserGroupPermission_Menu");

				entity.HasOne(d => d.UserGroup)
					.WithMany(p => p.UserGroupPermissions)
					.HasForeignKey(d => d.UserGroupId)
					.HasConstraintName("FK_UserGroupPermission_UserGroups");
			});

			modelBuilder.Entity<UserPrivilege>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.MenuId).HasColumnName("MenuID");

				entity.Property(e => e.UserId).HasColumnName("UserID");
			});

			modelBuilder.Entity<UserWarehouse>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserWarehouses)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_UserWarehouses_Users");

				entity.HasOne(d => d.Warehouse)
					.WithMany(p => p.UserWarehouses)
					.HasForeignKey(d => d.WarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserWarehouses_Warehouses");
			});

			modelBuilder.Entity<Vattype>(entity =>
			{
				entity.ToTable("VATTypes");

				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Vatpercentage)
					.HasColumnType("decimal(19, 4)")
					.HasColumnName("VATPercentage");
			});

			modelBuilder.Entity<Warehouse>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BranchId).HasColumnName("BranchID");

				entity.Property(e => e.CostingTypeId).HasColumnName("CostingTypeID");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.WarehouseTypeId).HasColumnName("WarehouseTypeID");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.Warehouses)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Warehouses_Accounts");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Warehouses)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Warehouses_Branches");

				entity.HasOne(d => d.CostingType)
					.WithMany(p => p.Warehouses)
					.HasForeignKey(d => d.CostingTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Warehouses_CostingTypes");

				entity.HasOne(d => d.WarehouseType)
					.WithMany(p => p.Warehouses)
					.HasForeignKey(d => d.WarehouseTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Warehouses_WarehouseTypes");
			});

			modelBuilder.Entity<WarehouseType>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("ID");

				entity.Property(e => e.ArabicName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Description)
					.HasMaxLength(250)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.EnglishName)
					.HasMaxLength(100)
					.HasDefaultValueSql("('')");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
