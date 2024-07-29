using Microsoft.EntityFrameworkCore;
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
    public class SupplierServices: ISupplierServices
    {
        private readonly IDevelopERPContext _context;

        public SupplierServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _context.Suppliers.Where(x => !x.IsDeleted).ToList();
        }

        public Supplier GetSupplier(int id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public void AddSupplier(SupplierDTO supplier)
        {
            var addSupplier = new Supplier
            {
                IsDeleted = false,
                AccountId = supplier.AccountId,
                AccountPayableId = supplier.AccountPayableId,
                ArabicAddress = supplier.ArabicAddress,
                ChargePersonArabicName = supplier.ChargePersonArabicName,
                ChargePersonEmail = supplier.ChargePersonEmail,
                ChargePersonEnglishName = supplier.ChargePersonEnglishName,
                ChargePersonJob = supplier.ChargePersonJob,
                ChargePersonMobile = supplier.ChargePersonMobile,
                ArabicName = supplier.ArabicName,
                CityId = supplier.CityId,
                Description = supplier.Description,
                Email = supplier.Email,
                EnglishAddress = supplier.EnglishAddress,
            EnglishName = supplier.EnglishName,
                FaxNo = supplier.FaxNo,
                MobileNo = supplier.MobileNo,
                ShippingTypeId = supplier.ShippingTypeId,
                SupplierActivityId = supplier.SupplierActivityId,
                SupplierGroupId = supplier.SupplierGroupId,
                TelephoneNo = supplier.TelephoneNo,
                SupplierTypeId = supplier.SupplierTypeId,
                Website = supplier.Website,
                City = null,
                ShippingType = null,
                SupplierActivity = null,
                SupplierGroup = null,
                Account = null,
                SupplierType = null,
                Active = true,

            };

            _context.Suppliers.Add(addSupplier);
            _context.SaveChanges();
        }

        public void EditSupplier(int id, SupplierDTO supplier)
        {
            try
            {
                var existingSupplier = _context.Suppliers.FirstOrDefault(x => x.Id == id);

                if (existingSupplier != null)
                {
                    // Update properties from the DTO

                    existingSupplier.AccountId = supplier.AccountId;
                    existingSupplier.AccountPayableId = supplier.AccountPayableId;
                    existingSupplier.ArabicAddress = supplier.ArabicAddress;
                    existingSupplier.ChargePersonArabicName = supplier.ChargePersonArabicName;
                    existingSupplier.ChargePersonEmail = supplier.ChargePersonEmail;
                    existingSupplier.ChargePersonEnglishName = supplier.ChargePersonEnglishName;
                    existingSupplier.ChargePersonJob = supplier.ChargePersonJob;
                    existingSupplier.ChargePersonMobile = supplier.ChargePersonMobile;
                    existingSupplier.ArabicName = supplier.ArabicName;
                    existingSupplier.CityId = supplier.CityId;
                    existingSupplier.Description = supplier.Description;
                    existingSupplier.Email = supplier.Email;
                    existingSupplier.EnglishAddress = supplier.EnglishAddress;
                    existingSupplier.EnglishName = supplier.EnglishName;
                    existingSupplier.FaxNo = supplier.FaxNo;
                    existingSupplier.MobileNo = supplier.MobileNo;
                    existingSupplier.ShippingTypeId = supplier.ShippingTypeId;
                    existingSupplier.SupplierActivityId = supplier.SupplierActivityId;
                    existingSupplier.SupplierGroupId = supplier.SupplierGroupId;
                    existingSupplier.TelephoneNo = supplier.TelephoneNo;
                    existingSupplier.SupplierTypeId = supplier.SupplierTypeId;
                    existingSupplier.Website = supplier.Website;
                    //existingSupplier.Active = true;
                    //existingSupplier.IsDeleted = false;

                    // Save changes to the database
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine("Error editing supplier: " + ex.Message);
                // Optionally, you can re-throw the exception for handling at a higher level
                throw;
            }
        }


        public void DeleteSupplier(int id)
        {
            var existingSupplier = _context.Suppliers.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existingSupplier != null)
            {
                // Mark the supplier as deleted
                existingSupplier.IsDeleted = true;
                existingSupplier.Active = false;

                // Save changes to the database
                _context.SaveChanges();
            }
        }


    }
}
