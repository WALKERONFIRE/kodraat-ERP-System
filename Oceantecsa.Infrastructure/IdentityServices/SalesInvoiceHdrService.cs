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
    public class SalesInvoiceHdrService : ISalesInvoiceHdrService
    {

        private readonly IDevelopERPContext _context;

        public SalesInvoiceHdrService(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesInvoiceHdr> GetAllSalesInvoiceHdrs()
        {
            return _context.SalesInvoiceHdrs
                .Where(hdr => !hdr.IsDeleted)
                .Include(hdr => hdr.SalesInvoiceDtls)
                .ToList();
        }

        public SalesInvoiceHdr GetSalesInvoiceHdr(long id)
        {
            return _context.SalesInvoiceHdrs
                .SingleOrDefault(hdr => hdr.Id == id && !hdr.IsDeleted);
        }
        public SalesInvoiceHdr AddSalesInvoiceHdr(SalesInvoiceHdrDTO salesInvoiceHdrDTO)
        {
            try
            {
                // Calculate the new ID (assuming it's an auto-incremented identity column)
                var currentMaxId = _context.SalesInvoiceHdrs.Max(s => s.Id);
                var newId = currentMaxId + 1;

                var salesInvoiceHdr = new SalesInvoiceHdr
                {
                    Id = newId,
                    SalesInvoiceId = salesInvoiceHdrDTO.SalesInvoiceId,
                    TypeId = salesInvoiceHdrDTO.TypeId,
                    SalesCashTypeId = salesInvoiceHdrDTO.SalesCashTypeId,
                    BranchId = salesInvoiceHdrDTO.BranchId,
                    WarehouseId = salesInvoiceHdrDTO.WarehouseId,
                    LocationId = salesInvoiceHdrDTO.LocationId,
                    CustomerId = salesInvoiceHdrDTO.CustomerId,
                    InvoiceDate = salesInvoiceHdrDTO.InvoiceDate,
                    InvoiceDescription = salesInvoiceHdrDTO.InvoiceDescription,
                    OriginalValue = 0,
                    DiscountPercent = salesInvoiceHdrDTO.DiscountPercent,
                    DiscountValue = 0,
                    NetValue = 0,
                    VatPercent = 0,
                    VatValue = 0,
                    InvoiceValue = 0,
                    PaidValue = salesInvoiceHdrDTO.PaidValue,
                    JournalId = salesInvoiceHdrDTO.JournalId,
                    GroupOfferId = salesInvoiceHdrDTO.GroupOfferId,
                    ItemOfferId = salesInvoiceHdrDTO.ItemOfferId,
                    SpecialOfferId = salesInvoiceHdrDTO.SpecialOfferId,
                    CreatedDate = salesInvoiceHdrDTO.CreatedDate,
                    CreatedUser = salesInvoiceHdrDTO.CreatedUser,
                    ModifiedDate = salesInvoiceHdrDTO.ModifiedDate,
                    ModifiedUser = salesInvoiceHdrDTO.ModifiedUser,
                    PostedDate = salesInvoiceHdrDTO.PostedDate,
                    PostedUser = salesInvoiceHdrDTO.PostedUser,
                    Posted = false, // Set to false by default
                    IsDeleted = false // Set to false by default
                };

                _context.SalesInvoiceHdrs.Add(salesInvoiceHdr);
                _context.SaveChanges();

                // Calculate the sums and averages for SalesInvoiceDtl
                UpdateSalesInvoiceHdrProperties(salesInvoiceHdr.Id);

                return salesInvoiceHdr;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                throw ex;
            }
        }

        public SalesInvoiceHdr UpdateSalesInvoiceHdr(long id, SalesInvoiceHdrDTO updatedSalesInvoiceHdrDTO)
        {
            try
            {
                var existingSalesInvoiceHdr = _context.SalesInvoiceHdrs
                    .SingleOrDefault(hdr => hdr.Id == id);

                if (existingSalesInvoiceHdr == null)
                {
                    return null;
                }

                // Check if the record is already posted; prevent update if posted
                if (existingSalesInvoiceHdr.Posted)
                {
                    return null;
                }

                // Update properties from updatedSalesInvoiceHdrDTO
                existingSalesInvoiceHdr.SalesInvoiceId = updatedSalesInvoiceHdrDTO.SalesInvoiceId;
                existingSalesInvoiceHdr.TypeId = updatedSalesInvoiceHdrDTO.TypeId;
                existingSalesInvoiceHdr.SalesCashTypeId = updatedSalesInvoiceHdrDTO.SalesCashTypeId;
                existingSalesInvoiceHdr.BranchId = updatedSalesInvoiceHdrDTO.BranchId;
                existingSalesInvoiceHdr.WarehouseId = updatedSalesInvoiceHdrDTO.WarehouseId;
                existingSalesInvoiceHdr.LocationId = updatedSalesInvoiceHdrDTO.LocationId;
                existingSalesInvoiceHdr.CustomerId = updatedSalesInvoiceHdrDTO.CustomerId;
                existingSalesInvoiceHdr.InvoiceDate = updatedSalesInvoiceHdrDTO.InvoiceDate;
                existingSalesInvoiceHdr.InvoiceDescription = updatedSalesInvoiceHdrDTO.InvoiceDescription;
                existingSalesInvoiceHdr.PaidValue = updatedSalesInvoiceHdrDTO.PaidValue;
                existingSalesInvoiceHdr.JournalId = updatedSalesInvoiceHdrDTO.JournalId;
                existingSalesInvoiceHdr.GroupOfferId = updatedSalesInvoiceHdrDTO.GroupOfferId;
                existingSalesInvoiceHdr.ItemOfferId = updatedSalesInvoiceHdrDTO.ItemOfferId;
                existingSalesInvoiceHdr.SpecialOfferId = updatedSalesInvoiceHdrDTO.SpecialOfferId;
                existingSalesInvoiceHdr.ModifiedDate = updatedSalesInvoiceHdrDTO.ModifiedDate;
                existingSalesInvoiceHdr.ModifiedUser = updatedSalesInvoiceHdrDTO.ModifiedUser;
                existingSalesInvoiceHdr.PostedDate = updatedSalesInvoiceHdrDTO.PostedDate;
                existingSalesInvoiceHdr.PostedUser = updatedSalesInvoiceHdrDTO.PostedUser;

                // Calculate the sums and averages for SalesInvoiceDtl
                UpdateSalesInvoiceHdrProperties(existingSalesInvoiceHdr.Id);

                _context.SaveChanges();

                return existingSalesInvoiceHdr;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                throw ex;
            }
        }

        public SalesInvoiceHdr DeleteSalesInvoiceHdr(long id)
        {
            try
            {
                var existingSalesInvoiceHdr = _context.SalesInvoiceHdrs
                    .SingleOrDefault(hdr => hdr.Id == id);

                if (existingSalesInvoiceHdr == null)
                {
                    return null;
                }

                // Check if the record is already posted; prevent delete if posted
                if (existingSalesInvoiceHdr.Posted)
                {
                    return null;
                }

                existingSalesInvoiceHdr.IsDeleted = true;

                _context.SaveChanges();

                return existingSalesInvoiceHdr;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                throw ex;
            }
        }

        public SalesInvoiceHdr PostSalesInvoiceHdr(long id)
        {
            try
            {
                var existingSalesInvoiceHdr = _context.SalesInvoiceHdrs
                    .SingleOrDefault(hdr => hdr.Id == id);

                if (existingSalesInvoiceHdr == null)
                {
                    return null;
                }

                // Check if the record is already posted; prevent reposting
                if (existingSalesInvoiceHdr.Posted)
                {
                    return null;
                }

                existingSalesInvoiceHdr.Posted = true;

                _context.SaveChanges();

                return existingSalesInvoiceHdr;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                throw ex;
            }
        }

        private void UpdateSalesInvoiceHdrProperties(long id)
        {
            var salesInvoiceDtlSum = _context.SalesInvoiceDtls
                .Where(d => d.SalesInvoiceHdrId == id)
                .GroupBy(d => d.SalesInvoiceHdrId)
                .Select(group => new
                {
                    OriginalValue = group.Sum(d => d.TotalValue),
                    DiscountValue = group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / _context.SalesInvoiceHdrs.FirstOrDefault(hdr => hdr.Id == id).DiscountPercent),
                    NetValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / _context.SalesInvoiceHdrs.FirstOrDefault(hdr => hdr.Id == id).DiscountPercent)),
                    VatPercent = group.Average(d => d.VatPercent),
                    VatValue = group.Sum(d => d.VatValue),
                    InvoiceValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / _context.SalesInvoiceHdrs.FirstOrDefault(hdr => hdr.Id == id).DiscountPercent)) + group.Sum(d => d.VatValue),
                })
                .FirstOrDefault();

            if (salesInvoiceDtlSum != null)
            {
                var salesInvoiceHdr = _context.SalesInvoiceHdrs
                    .Where(hdr => hdr.Id == id)
                    .FirstOrDefault();

                if (salesInvoiceHdr != null)
                {
                    salesInvoiceHdr.OriginalValue = salesInvoiceDtlSum.OriginalValue;
                    salesInvoiceHdr.DiscountValue = salesInvoiceDtlSum.DiscountValue;
                    salesInvoiceHdr.NetValue = salesInvoiceDtlSum.NetValue;
                    salesInvoiceHdr.VatPercent = salesInvoiceDtlSum.VatPercent;
                    salesInvoiceHdr.VatValue = salesInvoiceDtlSum.VatValue;
                    salesInvoiceHdr.InvoiceValue = salesInvoiceDtlSum.InvoiceValue;
                }
            }
        }

    }
}
