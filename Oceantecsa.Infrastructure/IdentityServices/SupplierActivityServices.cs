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
    public class SupplierActivityServices:ISupplierActivityServices
    {
        private readonly IDevelopERPContext _context;

        public SupplierActivityServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<SupplierActivity> GetAllSupplierGroups()
        {
            return _context.SupplierActivities.Where(x => !x.IsDeleted).ToList();
        }

        public SupplierActivity GetSupplierActivity(int id)
        {
            return _context.SupplierActivities.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public void AddSupplierActivity(SupplierActivityDTO  supplierActivity)
        {
            var supplier = new SupplierActivity
            {
                IsDeleted = false,
                EnglishName = supplierActivity .EnglishName,
                Description = supplierActivity.Description,
                ArabicName = supplierActivity.ArabicName,
                Active = true,
                Suppliers = null,
            };

            _context.SupplierActivities.Add(supplier);
            _context.SaveChanges();
        }

        public void EditSupplierActivity(int id, SupplierActivityDTO  supplierActivity)
        {
            var existingSupplier = _context.SupplierActivities.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existingSupplier != null)
            {
                existingSupplier.EnglishName =  supplierActivity.EnglishName;
                existingSupplier.Description = supplierActivity.Description;
                existingSupplier.ArabicName = supplierActivity.ArabicName;
                existingSupplier.Active = true;
                existingSupplier.Suppliers = existingSupplier.Suppliers; // You may need to handle this property properly

                _context.SaveChanges();
            }
        }

        public void DeleteSupplierActivity(int id)
        {
            var existingSupplier = _context.SupplierActivities.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

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
