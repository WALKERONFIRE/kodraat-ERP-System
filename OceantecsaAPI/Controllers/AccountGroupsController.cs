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
    public class AccountGroupsController : ControllerBase
    {
        private readonly IAccountGroupsService _accountGroups;

        public AccountGroupsController(IAccountGroupsService accountGroups)
        {
            _accountGroups = accountGroups;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _accountGroups.GetAll());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var accountGroup = await _accountGroups.GetById(id);
            if (accountGroup is null)
                return BadRequest("Not Found");
            return Ok(accountGroup);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AccountGroupDto accountGroupsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var accountGroups = new AccountGroup()
            {
                EnglishName = accountGroupsDto.EnglishName,
                ArabicName = accountGroupsDto.ArabicName,
                Description = accountGroupsDto.Description,
                Active = accountGroupsDto.Active
            };
            await _accountGroups.Add(accountGroups);
            return Ok(accountGroups);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Edit(int id, AccountGroupDto accountGroupsDto)
        {
            var accountGroups = await _accountGroups.GetById(id);
            if (accountGroups == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                accountGroups.EnglishName = accountGroupsDto.EnglishName;
                accountGroups.ArabicName = accountGroupsDto.ArabicName;
                accountGroups.Description = accountGroupsDto.Description;
                accountGroups.Active = accountGroupsDto.Active;
                _accountGroups.Update(accountGroups);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_accountGroups.AccountGroupExists(accountGroups.Id))
                {
                    return BadRequest("Not Found");
                }
                else
                {
                    throw;
                }
            }
            return Ok(accountGroups);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var accountGroups = await _accountGroups.GetById(id);
            if (accountGroups == null)
                return BadRequest("Not Found");
            return Ok(_accountGroups.Delete(accountGroups));
        }
    }
}
