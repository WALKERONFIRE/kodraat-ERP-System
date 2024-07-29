using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    [ApiController]
    [Route("ReceiptTypes")]
    // [ValidateAntiForgeryToken]
    public class ReceiptTypesController : ControllerBase
    {
        public IDevelopERPContext _context;

        public ReceiptTypesController(IDevelopERPContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllReceiptType")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAccountLevels()
        {
            var receiptTypes = _context.ReceiptTypes.ToList();
            return Ok(receiptTypes);
        }

        [HttpGet("GetReceiptType")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetReceiptType(int id)
        {
            var receiptType = _context.ReceiptTypes.Where(m => m.Id == id).FirstOrDefault();

            if (receiptType == null)
            {
                return NotFound();
            }

            return Ok(receiptType);
        }

        [HttpPost("CreateReceiptType")]
        // [ValidateAntiForgeryToken]
        public ActionResult CreateAccountLevel([Bind("Id,EnglishName,ArabicName,Description,Active,IsDeleted")] ReceiptTypeDto receiptType)
        {
            ReceiptType receipt = new ReceiptType()
            {
                ArabicName = receiptType.ArabicName,
                EnglishName = receiptType.EnglishName,
                Description = receiptType.Description,
                Active = receiptType.Active,
                IsDeleted = receiptType.IsDeleted
            };
            _context.ReceiptTypes.Add(receipt);
            _context.SaveChanges();
            return Ok("Done");

        }

        [HttpPut("EditReceiptTypes")]
        public ActionResult EditReceiptTypes(int id, ReceiptTypeDto receiptType)
        {
            var checkAccount = _context.ReceiptTypes.AsNoTracking().Where(a => a.Id == id).FirstOrDefault();
            if (checkAccount == null)
            {
                return NotFound();
            }

            ReceiptType receipt = new ReceiptType()
            {
                Id = checkAccount.Id,
                ArabicName = receiptType.ArabicName,
                EnglishName = receiptType.EnglishName,
                Description = receiptType.Description,
                Active = receiptType.Active,
                IsDeleted = receiptType.IsDeleted
            };
            _context.ReceiptTypes.Update(receipt);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteReceiptTypes")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteReceiptTypes(int id)
        {
            var receiptType = _context.ReceiptTypes.AsNoTracking().Where(i => i.Id == id).FirstOrDefault();

            if (receiptType == null)
            {
                return NotFound();
            }

            _context.ReceiptTypes.Remove(receiptType);
            _context.SaveChanges();
            return Ok();
        }


    }
}
