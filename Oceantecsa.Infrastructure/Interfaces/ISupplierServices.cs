using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISupplierServices
    {
        IEnumerable<Supplier> GetAllSupplier();
        Supplier GetSupplier(int id);
        void AddSupplier(SupplierDTO  supplier);
        void EditSupplier(int id, SupplierDTO  supplier);
        void DeleteSupplier(int id);

    }
}
