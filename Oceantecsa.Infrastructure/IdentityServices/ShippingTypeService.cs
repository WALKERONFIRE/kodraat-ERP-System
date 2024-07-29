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
    public class ShippingTypeService:IShippingTypeService
    {
        private readonly IDevelopERPContext _context;

        public ShippingTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<ShippingType> GetAllShippingType()
        {
            return _context.ShippingTypes.Where(x => !x.IsDeleted).ToList();
        }

        public ShippingType GetShippingType(int id)
        {
            return _context.ShippingTypes.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public void AddShippingType(ShippingTypeDTO  shippingType)
        {
            var supplier = new ShippingType
            {
                IsDeleted = false,
                EnglishName = shippingType.EnglishName,
                Description = shippingType  .Description,
                ArabicName = shippingType.ArabicName,
                Active = true,
                 
                Suppliers = null,
            };

            _context.ShippingTypes.Add(supplier);
            _context.SaveChanges();
        }

        public void EditShippingType(int id, ShippingTypeDTO  shippingType)
        {
            var existingSupplier = _context.ShippingTypes.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existingSupplier != null)
            {
                existingSupplier.EnglishName = shippingType.EnglishName;
                existingSupplier.Description =  shippingType .Description;
                existingSupplier.ArabicName = shippingType.ArabicName;
                existingSupplier.Active = true;
                existingSupplier.Suppliers = existingSupplier.Suppliers; // You may need to handle this property properly

                _context.SaveChanges();
            }
        }

        public void DeleteShippingType(int id)
        {
            var existingSupplier = _context.ShippingTypes.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

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
