using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISalesCashTypeService
    {
        Task<IEnumerable<SalesCashType>> GetAll();

        Task<SalesCashType> GetById(int id);

        Task<SalesCashType> Add(SalesCashType salesCashType);
        SalesCashType Update(SalesCashType salesCashType);
        SalesCashType Delete(SalesCashType salesCashType);

        bool SalesCashTypeExists(int id);
    }
}
