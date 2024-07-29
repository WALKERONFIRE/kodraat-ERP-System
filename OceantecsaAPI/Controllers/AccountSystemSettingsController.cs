using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountSystemSettingsController : ControllerBase
    {
        private readonly IModuleAccountsDtlService _moduleAccountsDtlService;
        public AccountSystemSettingsController(IModuleAccountsDtlService moduleAccountsDtlService)
        {
            _moduleAccountsDtlService = moduleAccountsDtlService;
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(int ModuleAccountsHdrId)
        {
            var moduleAccountHdr = await _moduleAccountsDtlService.GetById(ModuleAccountsHdrId);
            if (moduleAccountHdr is null)
                return BadRequest("Not Found");
           return Ok(moduleAccountHdr);
        }
        [HttpPost]
        public async Task<IActionResult> Add(int accountsHdrId, ModuleAccountsDtlDto accountsDtl)
        {
            var moduleAccountHdr = await _moduleAccountsDtlService.GetById(accountsHdrId);
            if (moduleAccountHdr is null)
                return BadRequest("Not Found");
            return Ok(await _moduleAccountsDtlService.Add(accountsHdrId, accountsDtl));

        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, int accountsHdrId, ModuleAccountsDtlDto moduleAccounts)
        {
            var moduleAccountHdr = await _moduleAccountsDtlService.GetById(accountsHdrId);
            if (moduleAccountHdr is null)
                return BadRequest("Not Found");
            return Ok( _moduleAccountsDtlService.Update(id, accountsHdrId, moduleAccounts));
        }
    }
}
