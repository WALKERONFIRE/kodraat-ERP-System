using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IProductTypeService
    {
        Task<IEnumerable<ProductType>> GetAll();

        Task<ProductType> GetById(int id);

        Task<ProductType> Add(ProductType productType);
        ProductType Update(ProductType productType);
        ProductType Delete(ProductType productType);

        bool ProductTypeExists(int id);
    }
}
