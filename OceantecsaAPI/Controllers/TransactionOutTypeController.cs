using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.IdentityServices;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionOutTypeController : ControllerBase
    {
        private readonly ITransactionOutTypeService _transactionOutTypeService;

        public TransactionOutTypeController(ITransactionOutTypeService transactionOutTypeService)
        {
            _transactionOutTypeService = transactionOutTypeService;
        }

        [HttpGet("AllTransactionOutTypes")]
        public ActionResult GetAllTransactionOutTypes()
        {
            var types = _transactionOutTypeService.GetAllTransactionOutTypes();
            return Ok(types);
        }

        [HttpGet("GetTransactionOutType")]
        public ActionResult GetTransactionOutType(int id)
        {
            var type = _transactionOutTypeService.GetTransactionOutType(id);
            if (type != null)
            {
                return Ok(type);
            }
            return BadRequest();
        }

        [HttpPost("AddTransactionOutType")]
        public ActionResult AddTransactionOutType(TransactionOutTypeDTO cost)
        {
            _transactionOutTypeService.AddTransactionOutType(cost);
            return Ok();
        }

        [HttpDelete("DeleteTransactionOutType")]
        public ActionResult DeleteTransactionOutType(int id)
        {
            _transactionOutTypeService.DeleteTransactionOutType(id);
            return Ok();
        }

        [HttpPut("UpdateTransactionOutType")]
        public ActionResult UpdateTransactionOutType(int id, TransactionOutTypeDTO costing)
        {
            _transactionOutTypeService.UpdateTransactionOutType(id, costing);
            return Ok();
        }
    }
}
