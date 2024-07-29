using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.Services;
using Oceantecsa.Persistence.DataContext;
using OceantecsaAPI.Mappers;
using OceantecsaAPI.Services;
using System.Text.Json.Serialization;
using Zadbusiness.web.Services;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers()
	.AddJsonOptions(options =>
	{
		options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
	});
;


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAccountsService, AccountsService>();
builder.Services.AddTransient<IAccountActivitiesServices, AccountActivitiesServices>();
builder.Services.AddTransient<ICurrenciesService, CurrenciesServices>();
builder.Services.AddTransient<ICostExpensesTypesService, CostExpensesTypesService>();
builder.Services.AddTransient<IFinancialPeriodHdrsService, FinancialPeriodHdrsService>();
builder.Services.AddTransient<IJournalHeadersService , JournalHeadersService>();
builder.Services.AddTransient<IMeasurementUnitsService ,MeasurementUnitsService>();
builder.Services.AddTransient<IModuleAccountsDtlService ,ModuleAccountsDtlService>();
builder.Services.AddTransient<IVATTypeService , VATTypeService>();
builder.Services.AddTransient<IProductTypeService , ProductTypeService>();
builder.Services.AddTransient<IProductionTypeService , ProductionTypeService>();
builder.Services.AddTransient<IWarehouseTypesService, WarehouseTypesService>();
builder.Services.AddTransient<ISupplierTypesService, SupplierTypesService>();
builder.Services.AddTransient<IWarehousesService, WarehousesService>();
builder.Services.AddTransient<IAccountGroupsService, AccountGroupsService>();
builder.Services.AddTransient<IAccountSettingsService, AccountSettingsService>();
builder.Services.AddTransient<IBankService, BankService>();
builder.Services.AddTransient<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IBranchService, BranchService>();
builder.Services.AddTransient<IShelfService, ShelfService>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();
builder.Services.AddTransient<ITransactionInTypeService, TransactionInTypeService>();
builder.Services.AddTransient<ITransactionOutTypeService, TransactionOutTypeService>();
builder.Services.AddTransient<IAreaServices, AreaServices>();
builder.Services.AddTransient<IStateServices, StateServices>();
builder.Services.AddTransient<ISectionServices, SectionServices>();
builder.Services.AddTransient<ICustomerSerivce, CustomerService>();
builder.Services.AddTransient<ICustomerTypeService, CustomerTypeService>();
builder.Services.AddTransient<ICustomerGroupService, CustomerGroupService>();
builder.Services.AddTransient<ICustomerActivitySevice, CustomerActivityService>();
builder.Services.AddTransient<ISalesCashTypeService, SalesCashTypeService>();
builder.Services.AddTransient<ISalesReturnReasonService, SalesReturnReasonService>();
builder.Services.AddTransient<ISupplierActivityServices, SupplierActivityServices>();
builder.Services.AddTransient<ISupplierGroupServices, SupplierGroupServices>();
builder.Services.AddTransient<IShippingTypeService, ShippingTypeService>();
builder.Services.AddTransient<ISupplierServices, SupplierServices>();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<IProductUnitPricesService, ProductUnitPricesService>();
builder.Services.AddTransient<IJournalTypesService, JournalTypesService>();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<IProductUnitPricesService, ProductUnitPricesService>();
builder.Services.AddTransient<ITransactionInDtlService, TransactionInDtlService>();
builder.Services.AddTransient<ITransactionInHdrService, TransactionInHdrService>();
builder.Services.AddTransient<ISalesInvoiceDtiService, SalesInvoiceDtiService>();
builder.Services.AddTransient<ISalesInvoiceHdrService, SalesInvoiceHdrService>();
builder.Services.AddTransient<IPurchaseInvoiceHdrsService, PurchaseInvoiceHdrsService>();
builder.Services.AddTransient<IPurchaseInvoiceDtlsService, PurchaseInvoiceDtlsService>();
builder.Services.AddTransient<IPurchaseReturnHdrsService, PurchaseReturnHdrsService>();
builder.Services.AddTransient<IPurchaseReturnDtlsService, PurchaseReturnDtlsService>();
builder.Services.AddTransient<ICashboxTransactionHdrsService, CashboxTransactionHdrsService>();
builder.Services.AddTransient<ICashboxTransactionDtlsService, CashboxTransactionDtlsService>();
builder.Services.AddTransient<IPaymentByEmployeeReportsService, PaymentByEmployeeReportsService>();
builder.Services.AddTransient<IProductPrurchaseEarningReportsService, ProductPrurchaseEarningReportsService>();
builder.Services.AddTransient<ISupplierReportsService, SupplierReportsService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<IDevelopERPContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
app.UseRouting();
app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

