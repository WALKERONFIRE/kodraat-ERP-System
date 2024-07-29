using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    [ApiController]
    [Route("AccountLevels")]
    // [ValidateAntiForgeryToken]
    public class AccountLevelController : ControllerBase
    {
        public IDevelopERPContext _context;

        public AccountLevelController(IDevelopERPContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllAccountLevels")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAccountLevels()
        {
            var accountLevels = _context.AccountLevels.ToList();
            return Ok(accountLevels);
        }

        [HttpGet("GetAccountLevel")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAccountLevel(int id)
        {
            var accountLevel = _context.AccountLevels.Where(m => m.Id == id).FirstOrDefault();

            if (accountLevel == null)
            {
                return NotFound();
            }

            return Ok(accountLevel);
        }

        [HttpPost("CreateAccountLevel")]
        // [ValidateAntiForgeryToken]
        public ActionResult CreateAccountLevel([Bind("Id,EnglishName,ArabicName,Description,Active,IsDeleted")] AccountLevelDTO accountLevel)
        {
            AccountLevel account = new AccountLevel()
            {
                ArabicName = accountLevel.ArabicName,
                EnglishName = accountLevel.EnglishName,
                Description = accountLevel.Description,
                Active = accountLevel.Active,
                IsDeleted = accountLevel.IsDeleted
            };
            _context.AccountLevels.Add(account);
            _context.SaveChanges();
            return Ok("Done");

        }

        [HttpPut("EditAccountLevel")]
        // [ValidateAntiForgeryToken]
        public ActionResult EditAccountLevel(int id, AccountLevelDTO accountLevel)
        {
            var checkAccount = _context.AccountLevels.AsNoTracking().Where(a => a.Id == id).FirstOrDefault();
            if (checkAccount == null)
            {
                return NotFound();
            }

            AccountLevel account = new AccountLevel()
            {
                Id = checkAccount.Id,
                ArabicName = accountLevel.ArabicName,
                EnglishName = accountLevel.EnglishName,
                Description = accountLevel.Description,
                Active = accountLevel.Active,
                IsDeleted = accountLevel.IsDeleted
            };
            _context.AccountLevels.Update(account);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteAccountLevel")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteAccountLevel(int id)
        {
            var accountLevel = _context.AccountLevels.Where(i => i.Id == id).FirstOrDefault();

            if (accountLevel == null)
            {
                return NotFound();
            }

            _context.AccountLevels.Remove(accountLevel);
            _context.SaveChanges();

            return Ok();
        }

        private bool AccountLevelExists(int id)
        {
            return _context.AccountLevels.Any(e => e.Id == id);
        }
    }
}
