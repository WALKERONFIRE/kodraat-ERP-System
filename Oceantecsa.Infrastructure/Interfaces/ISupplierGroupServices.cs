using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISupplierGroupServices
    {
        IEnumerable<SupplierGroup> GetAllSupplierGroups();
        SupplierGroup GetSupplierGroup(int id);
        void AddSupplierGroup(SupplierGroupDTO supplierGroup);
        void EditSupplierGroup(int id, SupplierGroupDTO supplierGroup);
        void DeleteSupplierGroup(int id);
    }
}
