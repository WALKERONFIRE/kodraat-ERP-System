using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
    [ApiController]
    [Route("CostCenter")]
    // [ValidateAntiForgeryToken]
    public class CostCenterController : ControllerBase
    {
        public IDevelopERPContext _context;

        public CostCenterController(IDevelopERPContext context)
        {
            _context = context;
        }
        [HttpGet("getAllCosts")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetAll()
        {
            var getAll = _context.CostCenters.ToList();
            return Ok(getAll);
        }
        [HttpGet("getCost")]
        // [ValidateAntiForgeryToken]
        public ActionResult GetCost(int id)
        {
            var getCost = _context.CostCenters.Where(c => c.Id == id).FirstOrDefault();
            if (getCost == null)
            {
                return NotFound();
            }
            return Ok(getCost);
        }
        [HttpDelete("DeleteCost")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteCost(int id)
        {
            var cost = _context.CostCenters.Where(a => a.Id == id).FirstOrDefault();
            if (cost == null)
            {
                return NotFound();
            }
            _context.CostCenters.Remove(cost);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("AddCost")]
        // [ValidateAntiForgeryToken]
        public ActionResult AddCost(CostCenter costCenter)
        {
            _context.CostCenters.Add(costCenter);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("EditCost")]
        // [ValidateAntiForgeryToken]
        public ActionResult EditCost(int id, CostCenter costCenter)
        {

            var cost = _context.CostCenters.AsNoTracking().Where(c => c.Id == id).FirstOrDefault();
            if (cost == null)
            {
                return NotFound();
            }
            CostCenter cost1 = new CostCenter()
            {
                Id = costCenter.Id,
                Active = costCenter.Active,
                ArabicName = costCenter.ArabicName,
                CostLevel = costCenter.CostLevel,
                Description = costCenter.Description,
                EnglishName = costCenter.EnglishName,
                HaveSub = costCenter.HaveSub,
                IsDeleted = costCenter.IsDeleted,
                ParentId = costCenter.ParentId
            };
            _context.CostCenters.Update(cost1);
            _context.SaveChanges();
            return Ok();
        }

    }
}