using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountSettingsController : ControllerBase
    {
        private readonly IAccountSettingsService _accountSettings;

        public AccountSettingsController(IAccountSettingsService accountSettings)
        {
            _accountSettings = accountSettings;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _accountSettings.GetAll());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var accountGroup = await _accountSettings.GetById(id);
            if (accountGroup == null)
                return BadRequest("Not Found");
            return Ok(accountGroup);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AccountSettingDto accountSettingsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var accountSettings = new AccountingSetting()
            {
                AccountsLevel = accountSettingsDto.AccountsLevel,
                HasCostCenter = accountSettingsDto.HasCostCenter,
                CostCentersLevel = accountSettingsDto.CostCentersLevel,
                HasAccountActivity = accountSettingsDto.HasAccountActivity,
                AccountActivitiesLevel = accountSettingsDto.AccountActivitiesLevel,
                HasAccountAnalysis = accountSettingsDto.HasAccountAnalysis,
                AccountsPayableLevel = accountSettingsDto.AccountsPayableLevel,
                AccountsReceivableLevel = accountSettingsDto.AccountsReceivableLevel,
                HumanResourcesLevel = accountSettingsDto.HumanResourcesLevel,
                MainCashBoxAccountId = accountSettingsDto.MainCashBoxAccountId,
                MainWarehouseAccountId = accountSettingsDto.MainCashBoxAccountId,
                SystemAdmin = accountSettingsDto.SalesAdmin,
                AccountingAdmin = accountSettingsDto.AccountingAdmin,
                HumanResourcesAdmin = accountSettingsDto.HumanResourcesAdmin,
                ProductionAdmin = accountSettingsDto.ProductionAdmin,
                PurchasingAdmin = accountSettingsDto.PurchasingAdmin,
                SalesAdmin = accountSettingsDto.SalesAdmin,
                WarehousesAdmin = accountSettingsDto.WarehousesAdmin,
                Active = accountSettingsDto.Active
            };
            await _accountSettings.Add(accountSettings);
            return Ok(accountSettings);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Edit(int id,AccountSettingDto accountSettingsDto)
        {
            if (id == null)
                return BadRequest("Not Found");
            var accountSettings = await _accountSettings.GetById(id);
            if (accountSettings == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                accountSettings.AccountsLevel = accountSettingsDto.AccountsLevel;
                accountSettings.HasCostCenter = accountSettingsDto.HasCostCenter;
                accountSettings.CostCentersLevel = accountSettingsDto.CostCentersLevel;
                accountSettings.HasAccountActivity = accountSettingsDto.HasAccountActivity;
                accountSettings.AccountActivitiesLevel = accountSettingsDto.AccountActivitiesLevel;
                accountSettings.HasAccountAnalysis = accountSettingsDto.HasAccountAnalysis;
                accountSettings.AccountsPayableLevel = accountSettingsDto.AccountsPayableLevel;
                accountSettings.AccountsReceivableLevel = accountSettingsDto.AccountsReceivableLevel;
                accountSettings.HumanResourcesLevel = accountSettingsDto.HumanResourcesLevel;
                accountSettings.MainCashBoxAccountId = accountSettingsDto.MainCashBoxAccountId;
                accountSettings.MainWarehouseAccountId = accountSettingsDto.MainCashBoxAccountId;
                accountSettings.SystemAdmin = accountSettingsDto.SalesAdmin;
                accountSettings.AccountingAdmin = accountSettingsDto.AccountingAdmin;
                accountSettings.HumanResourcesAdmin = accountSettingsDto.HumanResourcesAdmin;
                accountSettings.ProductionAdmin = accountSettingsDto.ProductionAdmin;
                accountSettings.PurchasingAdmin = accountSettingsDto.PurchasingAdmin;
                accountSettings.SalesAdmin = accountSettingsDto.SalesAdmin;
                accountSettings.WarehousesAdmin = accountSettingsDto.WarehousesAdmin;
                accountSettings.Active = accountSettingsDto.Active;

                _accountSettings.Update(accountSettings);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_accountSettings.AccountExists(accountSettings.Id))
                {
                    return BadRequest("Not Found");
                }
                else
                {
                    throw;
                }
            }
            return Ok(accountSettings);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var accountSettings = await _accountSettings.GetById(id);
            if (accountSettings == null)
                return BadRequest("Not Found");
            return Ok(_accountSettings.Delete(accountSettings));
        }
    }
}
