using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISalesReturnReasonService
    {
        Task<IEnumerable<SalesReturnReason>> GetAll();

        Task<SalesReturnReason> GetById(int id);

        Task<SalesReturnReason> Add(SalesReturnReason salesReturnReason);
        SalesReturnReason Update(SalesReturnReason salesReturnReason);
        SalesReturnReason Delete(SalesReturnReason salesReturnReason);

        bool SalesReturnReasonExists(int id);
    }
}
