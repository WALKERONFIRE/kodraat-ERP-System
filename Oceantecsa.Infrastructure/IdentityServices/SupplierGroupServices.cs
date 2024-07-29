using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class SupplierGroupServices:ISupplierGroupServices
    {
        private readonly IDevelopERPContext _context;

        public SupplierGroupServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<SupplierGroup> GetAllSupplierGroups()
        {
            return _context.SupplierGroups.Where(x => !x.IsDeleted).ToList();
        }

        public SupplierGroup GetSupplierGroup(int id)
        {
            return _context.SupplierGroups.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public void AddSupplierGroup(SupplierGroupDTO supplierGroup)
        {
            var supplier = new SupplierGroup
            {
                IsDeleted = false,
                MainAccountId = supplierGroup.MainAccountId,
                EnglishName = supplierGroup.EnglishName,
                Description = supplierGroup.Description,
                ArabicName = supplierGroup.ArabicName,
                Active = true,
                Suppliers = null
            };

            _context.SupplierGroups.Add(supplier);
            _context.SaveChanges();
        }

        public void EditSupplierGroup(int id, SupplierGroupDTO supplierGroup)
        {
            var existingSupplier = _context.SupplierGroups.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existingSupplier != null)
            {
                existingSupplier.MainAccountId = supplierGroup.MainAccountId;
                existingSupplier.EnglishName = supplierGroup.EnglishName;
                existingSupplier.Description = supplierGroup.Description;
                existingSupplier.ArabicName = supplierGroup.ArabicName;
                existingSupplier.Active = true;
                existingSupplier.Suppliers = existingSupplier.Suppliers; // You may need to handle this property properly

                _context.SaveChanges();
            }
        }

        public void DeleteSupplierGroup(int id)
        {
            var existingSupplier = _context.SupplierGroups.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existingSupplier != null)
            {
                existingSupplier.IsDeleted = true;
                existingSupplier.Active = false;
                existingSupplier.Suppliers = existingSupplier.Suppliers; // You may need to handle this property properly

                _context.SaveChanges();
            }
        }
    }
}
