using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionInDtlController : ControllerBase
    {
        private readonly ITransactionInDtlService _transactionInDtlService;
        public TransactionInDtlController(ITransactionInDtlService transactionInDtlService)
        {
            _transactionInDtlService = transactionInDtlService;
        }
        [HttpPost]
        public IActionResult Add(TransactionInDtlDTO transactionInDtlDTO)
        {
            var transactionInDtl = new TransactionInDtl()
            {
                TransactionInHdrId = transactionInDtlDTO.TransactionInHdrId,
                ProductId = transactionInDtlDTO.ProductId,
                UnitId = transactionInDtlDTO.UnitId,
                Quantity = transactionInDtlDTO.Quantity,
                Cost = transactionInDtlDTO.Cost,
                ProductDescription = transactionInDtlDTO.ProductDescription,
                IsDeleted = transactionInDtlDTO.IsDeleted,
            };
            _transactionInDtlService.AddTransactionInDtl(transactionInDtl);
            return Ok(transactionInDtl);
        }
        [HttpPut]
        public IActionResult Update(long id, TransactionInDtlDTO transactionInDtlDTO)
        {
            var transactionInDtl = _transactionInDtlService.GetTransactionInDtl(id);

            transactionInDtl.TransactionInHdrId = transactionInDtlDTO.TransactionInHdrId;
            transactionInDtl.ProductId = transactionInDtlDTO.ProductId;
            transactionInDtl.UnitId = transactionInDtlDTO.UnitId;
            transactionInDtl.Quantity = transactionInDtlDTO.Quantity;
            transactionInDtl.Cost = transactionInDtlDTO.Cost;
            transactionInDtl.ProductDescription = transactionInDtlDTO.ProductDescription;
            transactionInDtl.IsDeleted = transactionInDtlDTO.IsDeleted;
            _transactionInDtlService.UpdateTransactionInDtl(transactionInDtl);
            return Ok(transactionInDtl);
        }
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            _transactionInDtlService.DeleteTransactionInDtl(id);
            return Ok("Deleted");
        }
    }
}
