using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class SalesInvoiceDtlController : ControllerBase
{
    private readonly ISalesInvoiceDtiService _salesInvoiceDtlService;

    public SalesInvoiceDtlController(ISalesInvoiceDtiService salesInvoiceDtlService)
    {
        _salesInvoiceDtlService = salesInvoiceDtlService;
    }

    [HttpGet("AllSalesInvoiceDtl")]
    public ActionResult<IEnumerable<SalesInvoiceDtl>> GetAllSalesInvoiceDtls()
    {
        try
        {
            var sales = _salesInvoiceDtlService.GetAllSalesInvoiceDtls();
            // Handle the response and return it as needed.
            return Ok(sales);
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }

    [HttpGet("SalesInvoiceDtl")]
    public ActionResult<IEnumerable<SalesInvoiceDtl>> GetSalesInvoiceDtls(int SalesInvoiceHdrId)
    {
        try
        {
            var sales = _salesInvoiceDtlService.GetSalesInvoiceDtls(SalesInvoiceHdrId);
            // Handle the response and return it as needed.
            return Ok(sales);
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }

    [HttpPost("AddSalesInvoiceDtl")]
    public ActionResult<SalesInvoiceDtl> AddSalesInvoiceDtl(SalesInvoiceDtlDTO salesInvoice)
    {
        try
        {
            var createdSalesInvoiceDtl = _salesInvoiceDtlService.AddSalesInvoiceDtl(salesInvoice);
            // Handle the response and return it as needed.
            return Ok(createdSalesInvoiceDtl);
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }

    [HttpDelete("DeleteSalesInvoiceDtl")]
    public ActionResult DeleteSalesInvoiceDtl(int SalesInvoiceHdrId, int productID)
    {
        try
        {
            _salesInvoiceDtlService.DeleteSalesInvoiceDtl(SalesInvoiceHdrId, productID);
            // Handle the response and return it as needed.
            return Ok();
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }

    [HttpPost("UpdateSalesInvoiceDtl")]
    public ActionResult<SalesInvoiceDtl> UpdateSalesInvoiceDtl(int SalesInvoiceHdrId, int productID, SalesInvoiceDtlDTO salesInvoice)
    {
        try
        {
            var updatedSalesInvoiceDtl = _salesInvoiceDtlService.UpdateSalesInvoiceDtl(SalesInvoiceHdrId, productID, salesInvoice);
            // Handle the response and return it as needed.
            return Ok(updatedSalesInvoiceDtl);
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }

    [HttpPost("ReturnedSalesInvoiceDtl")]
    public ActionResult<SalesInvoiceDtl> ReturnedSalesInvoiceDtl(int SalesInvoiceHdrId, int productID, int returnedQuantity, SalesInvoiceDtlDTO salesInvoice)
    {
        try
        {
            var updatedSalesInvoiceDtl = _salesInvoiceDtlService.ReturnedSalesInvoiceDtl(SalesInvoiceHdrId, productID, returnedQuantity, salesInvoice);
            // Handle the response and return it as needed.
            return Ok(updatedSalesInvoiceDtl);
        }
        catch (Exception ex)
        {
            // Handle exceptions and return an error response
            return BadRequest($"An error occurred: {ex.Message}");
        }
    }
}
