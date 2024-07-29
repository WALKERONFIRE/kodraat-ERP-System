using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISalesInvoiceHdrService
    {
        IEnumerable<SalesInvoiceHdr> GetAllSalesInvoiceHdrs();
        SalesInvoiceHdr GetSalesInvoiceHdr(long id);
        SalesInvoiceHdr AddSalesInvoiceHdr(SalesInvoiceHdrDTO salesInvoiceHdrDTO);
        SalesInvoiceHdr UpdateSalesInvoiceHdr(long id, SalesInvoiceHdrDTO updatedSalesInvoiceHdrDTO);
        SalesInvoiceHdr DeleteSalesInvoiceHdr(long id);
        SalesInvoiceHdr PostSalesInvoiceHdr(long id);
    }
}
