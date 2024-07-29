using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    [ApiController]
    [Route("CashBox")]
    public class CashBoxController : ControllerBase
    {

        public IDevelopERPContext _context;

        public CashBoxController(IDevelopERPContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllCashBox")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAllCashBox()
        {
            var CashBox = _context.CashBoxes.ToList();
            return Ok(CashBox);
        }

        [HttpGet("GetCashBox")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetCashBox(int id)
        {
            var cashBox = _context.CashBoxes.Where(m => m.Id == id).FirstOrDefault();

            if (cashBox == null)
            {
                return NotFound();
            }

            return Ok(cashBox);
        }

        [HttpPost("CreateCashBox")]
        // [ValidateAntiForgeryToken]
        public ActionResult CreateCashBox([Bind("Id,EnglishName,ArabicName,Description,Active,IsDeleted")] CashBoxDTO cashBox)
        {
            CashBox cash = new CashBox()
            {
                AccountId = cashBox.AccountId,
                Active = cashBox.Active,
                ArabicName = cashBox.ArabicName,
                BranchId = cashBox.BranchId,
                CurrencyId = cashBox.CurrencyId,
                CurrentBalance = cashBox.CurrentBalance,
                Description = cashBox.Description,
                EnglishName = cashBox.EnglishName,
                HasMaximumLimit = cashBox.HasMaximumLimit,
                IsDeleted = cashBox.IsDeleted,
                MaximumLimit = cashBox.MaximumLimit,
                OpeningBalance = cashBox.OpeningBalance,

            };
            _context.CashBoxes.Add(cash);
            _context.SaveChanges();
            return Ok("Done");

        }

        [HttpPut("EditCashBox")]
        // [ValidateAntiForgeryToken]
        public ActionResult EditCashBox(int id, CashBoxDTO cashBox)
        {
            var checkCashBox = _context.CashBoxes.AsNoTracking().Where(a => a.Id == id).FirstOrDefault();
            if (checkCashBox == null)
            {
                return NotFound();
            }

            CashBox cash = new CashBox()
            {
                Id = checkCashBox.Id,
                Account = checkCashBox.Account,
                Branch = checkCashBox.Branch,
                Currency = checkCashBox.Currency,
                UserCashBoxes = checkCashBox.UserCashBoxes,
                AccountId = cashBox.AccountId,
                Active = cashBox.Active,
                ArabicName = cashBox.ArabicName,
                BranchId = cashBox.BranchId,
                CurrencyId = cashBox.CurrencyId,
                CurrentBalance = cashBox.CurrentBalance,
                Description = cashBox.Description,
                EnglishName = cashBox.EnglishName,
                HasMaximumLimit = cashBox.HasMaximumLimit,
                IsDeleted = cashBox.IsDeleted,
                MaximumLimit = cashBox.MaximumLimit,
                OpeningBalance = cashBox.OpeningBalance,
            };
            _context.CashBoxes.Update(cash);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteCashBox")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteCashBox(int id)
        {
            var cashBox = _context.CashBoxes.Where(i => i.Id == id).FirstOrDefault();

            if (cashBox == null)
            {
                return NotFound();
            }

            _context.CashBoxes.Remove(cashBox);
            _context.SaveChanges();

            return Ok();
        }

    }
}
