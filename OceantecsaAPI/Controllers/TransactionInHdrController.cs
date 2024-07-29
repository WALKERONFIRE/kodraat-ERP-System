using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionInHdrController : ControllerBase
    {
        private readonly ITransactionInHdrService _transactionInHdrService;
        public TransactionInHdrController(ITransactionInHdrService transactionInHdrService)
        {
            _transactionInHdrService = transactionInHdrService;
        }
        [HttpPost]
        public IActionResult Add(TransactionInHdrDTO transactionInHdrDTO)
        {
            var transactionInHdr = new TransactionInHdr()
            {
                TransactionId = transactionInHdrDTO.TransactionId,
                TypeId = transactionInHdrDTO.TypeId,
                InBranchId     = transactionInHdrDTO.InBranchId,   
                InWarehouseId  = transactionInHdrDTO.InWarehouseId ,
                InLocationId   = transactionInHdrDTO.InLocationId , 
                OutBranchId    = transactionInHdrDTO.OutBranchId ,  
                OutWarehouseId = transactionInHdrDTO.OutWarehouseId,
                OutLocationId  = transactionInHdrDTO.OutLocationId

            };
            _transactionInHdrService.AddTransactionInHdr(transactionInHdr);
            return Ok(transactionInHdr);
        }
        [HttpPut]
        public IActionResult Update(long id,TransactionInHdrDTO transactionInHdrDTO)
        {
            var transactionInHdr = _transactionInHdrService.GetTransactionInHdr(id);

            transactionInHdr.TransactionId = transactionInHdrDTO.TransactionId;
            transactionInHdr.TypeId = transactionInHdrDTO.TypeId;
            transactionInHdr.InBranchId = transactionInHdrDTO.InBranchId;
            transactionInHdr.InWarehouseId = transactionInHdrDTO.InWarehouseId;
            transactionInHdr.InLocationId = transactionInHdrDTO.InLocationId;
            transactionInHdr.OutBranchId = transactionInHdrDTO.OutBranchId;
            transactionInHdr.OutWarehouseId = transactionInHdrDTO.OutWarehouseId;
            transactionInHdr.OutLocationId = transactionInHdrDTO.OutLocationId;

            
            _transactionInHdrService.UpdateTransactionInHdr(transactionInHdr);
            return Ok(transactionInHdr);
        }
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            _transactionInHdrService.DeleteTransactionInHdr(id);
            return Ok("Deleted");
        }
    }
}
