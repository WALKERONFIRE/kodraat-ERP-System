using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISupplierActivityServices
    {
        IEnumerable<SupplierActivity> GetAllSupplierGroups();
        SupplierActivity GetSupplierActivity(int id);
        void AddSupplierActivity(SupplierActivityDTO  supplierActivity);
        void EditSupplierActivity(int id, SupplierActivityDTO  supplierActivity);
        void DeleteSupplierActivity(int id);

    }
}
