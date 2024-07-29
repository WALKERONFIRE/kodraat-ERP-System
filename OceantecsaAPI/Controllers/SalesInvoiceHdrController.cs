using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System.Linq;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesInvoiceHdrController : ControllerBase
    {
        private readonly IDevelopERPContext _context;
        private readonly ISalesInvoiceHdrService _salesInvoiceHdrService;

        public SalesInvoiceHdrController(IDevelopERPContext context, ISalesInvoiceHdrService salesInvoiceHdrService)
        {
            _context = context;
            _salesInvoiceHdrService = salesInvoiceHdrService;
        }

        [HttpGet("AllSalesInvoiceHdr")]
        public ActionResult<IEnumerable<SalesInvoiceHdr>> AllSalesInvoiceHdr()
        {
            var AllSalesInvoiceHdr = _salesInvoiceHdrService.GetAllSalesInvoiceHdrs();
            return Ok(AllSalesInvoiceHdr);
        }

        [HttpGet("GetSalesInvoiceHdr")]
        public ActionResult<SalesInvoiceHdr> GetSalesInvoiceHdr(long id)
        {
            var salesInvoiceHdr = _salesInvoiceHdrService.GetSalesInvoiceHdr(id);

            if (salesInvoiceHdr != null)
            {
                return Ok(salesInvoiceHdr);
            }

            return NotFound();
        }

        [HttpPost("AddSalesInvoiceHdr")]
        public ActionResult<SalesInvoiceHdr> AddSalesInvoiceHdr(SalesInvoiceHdrDTO salesInvoiceHdrDTO)
        {
            var result = _salesInvoiceHdrService.AddSalesInvoiceHdr(salesInvoiceHdrDTO);

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Failed to add SalesInvoiceHdr.");
        }

        [HttpPut("UpdateSalesInvoiceHdr")]
        public ActionResult<SalesInvoiceHdr> UpdateSalesInvoiceHdr(long id, SalesInvoiceHdrDTO updatedSalesInvoiceHdrDTO)
        {
            var result = _salesInvoiceHdrService.UpdateSalesInvoiceHdr(id, updatedSalesInvoiceHdrDTO);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpDelete("DeleteSalesInvoiceHdr")]
        public ActionResult<SalesInvoiceHdr> DeleteSalesInvoiceHdr(long id)
        {
            var result = _salesInvoiceHdrService.DeleteSalesInvoiceHdr(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPut("PostSalesInvoiceHdr")]
        public ActionResult<SalesInvoiceHdr> PostSalesInvoiceHdr(long id)
        {
            var result = _salesInvoiceHdrService.PostSalesInvoiceHdr(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}