using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISalesInvoiceDtiService
    {
        IEnumerable<SalesInvoiceDtl> GetAllSalesInvoiceDtls();
        IEnumerable<SalesInvoiceDtl> GetSalesInvoiceDtls(int salesInvoiceHdrId);
        SalesInvoiceDtl AddSalesInvoiceDtl(SalesInvoiceDtlDTO salesInvoice);
        bool DeleteSalesInvoiceDtl(int salesInvoiceHdrId, int productID);
        SalesInvoiceDtl UpdateSalesInvoiceDtl(int salesInvoiceHdrId, int productID, SalesInvoiceDtlDTO salesInvoice);
        SalesInvoiceDtl ReturnedSalesInvoiceDtl(int salesInvoiceHdrId, int productID, int returnedQuantity, SalesInvoiceDtlDTO salesInvoice);
    }
}
