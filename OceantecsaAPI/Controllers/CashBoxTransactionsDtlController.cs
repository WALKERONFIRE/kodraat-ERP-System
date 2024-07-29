using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    public class CashBoxTransactionsDtlController : ControllerBase
    {
        private readonly IDevelopERPContext _context;
        public CashBoxTransactionsDtlController(IDevelopERPContext context)
        {
            _context = context;
        }
        [HttpGet("GetAll")]
        public IActionResult Getall()
        {
            var transaction = _context.CashBoxTransactionsDtls.ToList();
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }

        [HttpPost("GetByID")]
        public IActionResult GetByID(int id)
        {
            var cash = _context.CashBoxTransactionsDtls.Where(x => x.Id == id).FirstOrDefault();
            if (cash == null)
            {
                return NotFound();
            }
            return Ok(cash);
        }
        [HttpPost("insert")]
        public IActionResult Insert([FromBody] CashBoxTransactionsDtl cashBoxTransactionDtl)
        {
            var account=_context.BankAccounts.AsNoTracking().Where(x => x.AccountId==cashBoxTransactionDtl.AccountId).FirstOrDefault();
            if (account == null) { 
            return NotFound();
            }
            var accountAdd = new BankAccount()
            {
                AccountId = account.AccountId,
                Id = account.Id,
                Account = account.Account,
                Active = account.Active,
                Bank = account.Bank,
                BankAccountNo = account.BankAccountNo,
                BankId = account.BankId,
                Currency = account.Currency,
                CurrencyId = account.CurrencyId,
                CurrentBalance = account.CurrentBalance + cashBoxTransactionDtl.LocalDebit+cashBoxTransactionDtl.ForeignDebit,
                Description = account.Description,
                HasMaximumLimit = account.HasMaximumLimit,
                IsDeleted = account.IsDeleted,
                MaximumLimit = account.MaximumLimit,
                OpeningBalance = account.OpeningBalance,
                UserBankAccounts = account.UserBankAccounts

            };
            _context.BankAccounts.Update(accountAdd);
            _context.SaveChanges();
            _context.CashBoxTransactionsDtls.Add(cashBoxTransactionDtl);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(int id,[FromBody] CashBoxTransactionsDtl cashBoxTransactionDtl)
        {
            var account = _context.BankAccounts.AsNoTracking().Where(x => x.AccountId == cashBoxTransactionDtl.AccountId).FirstOrDefault();
            if (account == null)
            {
                return NotFound();
            }
            var accountAdd = new BankAccount()
            {
                AccountId = account.AccountId,
                Id = account.Id,
                Account = account.Account,
                Active = account.Active,
                Bank = account.Bank,
                BankAccountNo = account.BankAccountNo,
                BankId = account.BankId,
                Currency = account.Currency,
                CurrencyId = account.CurrencyId,
                CurrentBalance = account.CurrentBalance + cashBoxTransactionDtl.LocalDebit,
                Description = account.Description,
                HasMaximumLimit = account.HasMaximumLimit,
                IsDeleted = account.IsDeleted,
                MaximumLimit = account.MaximumLimit,
                OpeningBalance = account.OpeningBalance,
                UserBankAccounts = account.UserBankAccounts

            };
            _context.BankAccounts.Update(accountAdd);
            _context.SaveChanges();
            _context.CashBoxTransactionsDtls.Update(cashBoxTransactionDtl);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var transaction = _context.CashBoxTransactionsDtls.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
            if (transaction == null)
            {
                return NotFound();
            }
            _context.CashBoxTransactionsDtls.Remove(transaction);
            _context.SaveChanges();
            return Ok();
        }
    }
}