using AutoMapper;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.DTOS;

namespace OceantecsaAPI.Mappers
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Currency, CurrencyDto>();
			CreateMap<CurrencyDto, Currency>();

			CreateMap<CostExpensesType, CostExpensesTypeDto>();
			CreateMap<CostExpensesTypeDto, CostExpensesType>();

			CreateMap<FinancialPeriodHdr, FinancialPeriodHdrDto>();
			CreateMap<FinancialPeriodHdrDto, FinancialPeriodHdr>();

			CreateMap<JournalHdr, JournalHdrDto>();
			CreateMap<JournalHdrDto, JournalHdrDto>();

			CreateMap<CostExpensesType, CostExpensesTypeDto>();
			CreateMap<CostExpensesTypeDto, CostExpensesType>();

			CreateMap<WarehouseType, WarehouseTypeDto>();
			CreateMap<WarehouseTypeDto, WarehouseType>();

			CreateMap<SupplierType, SupplierTypeDto>();
			CreateMap<SupplierTypeDto, SupplierType>();

			CreateMap<Warehouse, WarehouseDto>();
			CreateMap<WarehouseDto, Warehouse>();

			CreateMap<Branch, BranchDto>();
			CreateMap<BranchDto, Branch>();

			CreateMap<Product, ProductDto>();
			CreateMap<ProductDto, Product>();

			CreateMap<PurchaseInvoiceHdr, PurchaseInvoiceHdrDto>();
			CreateMap<PurchaseInvoiceHdrDto, PurchaseInvoiceHdr>();

			CreateMap<JournalType, JournalTypeDto>();
			CreateMap<JournalTypeDto, JournalType>();

			CreateMap<PurchaseReturnHdr, PurchaseReturnHdrDto>();
			CreateMap<PurchaseReturnHdrDto, PurchaseReturnHdr>();

			CreateMap<Account, CreateAccountDto>();
			CreateMap<CreateAccountDto, Account>();

			CreateMap<CashBoxTransactionsHdr, CashBoxTransactionsHdrDTO>();
			CreateMap<CashBoxTransactionsHdrDTO, CashBoxTransactionsHdr>();


			// Add more CreateMap calls for other mappings if needed
		}

	}
}
