using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IProductionTypeService
    {
        Task<IEnumerable<ProductProductionType>> GetAll();

        Task<ProductProductionType> GetById(int id);

        Task<ProductProductionType> Add(ProductProductionType productProductionType);
        ProductProductionType Update(ProductProductionType productProductionType);
        ProductProductionType Delete(ProductProductionType productProductionType);

        bool ProductProductionTypeExists(int id);
    }
}
