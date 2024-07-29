using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.IdentityServices;
namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionInTypeController : ControllerBase
    {
        private readonly ITransactionInTypeService _transactionInTypeService;

        public TransactionInTypeController(ITransactionInTypeService transactionInTypeService)
        {
            _transactionInTypeService = transactionInTypeService;
        }

        [HttpGet("AllTransactionInTypes")]
        public ActionResult GetAllTransactionInTypes()
        {
            var types = _transactionInTypeService.GetAllTransactionInTypes();
            return Ok(types);
        }

        [HttpGet("GetTransactionInType")]
        public ActionResult GetTransactionInType(int id)
        {
            var type = _transactionInTypeService.GetTransactionInType(id);
            if (type != null)
            {
                return Ok(type);
            }
            return BadRequest();
        }

        [HttpPost("AddTransactionInType")]
        public ActionResult AddTransactionInType(TransactionInTypeDTO cost)
        {
            _transactionInTypeService.AddTransactionInType(cost);
            return Ok();
        }

        [HttpDelete("DeleteTransactionInType")]
        public ActionResult DeleteTransactionInType(int id)
        {
            _transactionInTypeService.DeleteTransactionInType(id);
            return Ok();
        }

        [HttpPut("UpdateTransactionInType")]
        public ActionResult UpdateTransactionInType(int id, TransactionInTypeDTO costing)
        {
            _transactionInTypeService.UpdateTransactionInType(id, costing);
            return Ok();
        }
    }
}
