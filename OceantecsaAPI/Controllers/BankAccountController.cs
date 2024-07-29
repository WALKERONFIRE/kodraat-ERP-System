using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    [ApiController]
    [Route("BankAccount")]
    public class BankAccountController : ControllerBase
    {
        public IDevelopERPContext _context;

        public BankAccountController(IDevelopERPContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllBankAccount")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAllBankAccount()
        {
            var bankAccounts = _context.BankAccounts.ToList();
            return Ok(bankAccounts);
        }

        [HttpGet("GetBankAccount")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetBankAccount(int id)
        {
            var bankAccount = _context.BankAccounts.Where(m => m.Id == id).FirstOrDefault();

            if (bankAccount == null)
            {
                return NotFound();
            }

            return Ok(bankAccount);
        }

        [HttpPost("CreateBankAccount")]
        public ActionResult CreateBankAccount([Bind("Id,EnglishName,ArabicName,Description,Active,IsDeleted")] BankAccountDTO bankAccount)
        {
            try
            {
                BankAccount bank = new BankAccount()
                {
                    Active = bankAccount.Active,
                    BankAccountNo = bankAccount.BankAccountNo,
                    CurrencyId = bankAccount.CurrencyId,
                    AccountId = bankAccount.AccountId,
                    CurrentBalance = bankAccount.CurrentBalance,
                    Description = bankAccount.Description,
                    HasMaximumLimit = bankAccount.HasMaximumLimit,
                    IsDeleted = bankAccount.IsDeleted,
                    MaximumLimit = bankAccount.MaximumLimit,
                    OpeningBalance = bankAccount.OpeningBalance
                };

                // Ensure the provided BankId exists in the Banks table before adding the bank account.
                if (_context.Banks.Any(b => b.Id == bankAccount.BankId))
                {
                    bank.BankId = bankAccount.BankId;
                    _context.BankAccounts.Add(bank);
                    _context.SaveChanges();
                    return Ok("Done");
                }
                else
                {
                    return BadRequest("Invalid BankId");
                }
            }
            catch (Exception ex)
            {
                // Handle and log the exception here.
                return StatusCode(500, "An error occurred while saving the bank account.");
            }
        }


        [HttpPut("EditBankAccount")]
        // [ValidateAntiForgeryToken]
        public ActionResult EditBankAccount(int id, BankAccountDTO bankAccount)
        {
            var checkAccount = _context.BankAccounts.AsNoTracking().Where(a => a.Id == id).FirstOrDefault();
            if (checkAccount == null)
            {
                return NotFound();
            }

            BankAccount bank = new BankAccount()
            {
                Id = checkAccount.Id,
                Active = bankAccount.Active,
                BankAccountNo = bankAccount.BankAccountNo,
                CurrencyId = bankAccount.CurrencyId,
                AccountId = bankAccount.AccountId,
                BankId = bankAccount.BankId,
                CurrentBalance = bankAccount.CurrentBalance,
                Description = bankAccount.Description,
                HasMaximumLimit = bankAccount.HasMaximumLimit,
                IsDeleted = bankAccount.IsDeleted,
                MaximumLimit = bankAccount.MaximumLimit,
                OpeningBalance = bankAccount.OpeningBalance,
                UserBankAccounts = checkAccount.UserBankAccounts,
                Account = checkAccount.Account,
                Bank = checkAccount.Bank,
                Currency = checkAccount.Currency
            };
            _context.BankAccounts.Update(bank);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteBankAccount")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteBankAccount(int id)
        {
            var checkAccount = _context.BankAccounts.Where(i => i.Id == id).FirstOrDefault();

            if (checkAccount == null)
            {
                return NotFound();
            }

            _context.BankAccounts.Remove(checkAccount);
            _context.SaveChanges();

            return Ok();
        }


    }
}