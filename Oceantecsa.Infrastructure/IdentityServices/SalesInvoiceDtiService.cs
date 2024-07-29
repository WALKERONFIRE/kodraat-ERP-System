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
    public class SalesInvoiceDtiService : ISalesInvoiceDtiService
    {
        private readonly IDevelopERPContext _context;

        public SalesInvoiceDtiService(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesInvoiceDtl> GetAllSalesInvoiceDtls()
        {
            return _context.SalesInvoiceDtls.Where(s => !s.IsDeleted).ToList();
        }

        public IEnumerable<SalesInvoiceDtl> GetSalesInvoiceDtls(int salesInvoiceHdrId)
        {
            return _context.SalesInvoiceDtls.Where(s => s.SalesInvoiceHdrId == salesInvoiceHdrId).ToList();
        }

        public SalesInvoiceDtl AddSalesInvoiceDtl(SalesInvoiceDtlDTO salesInvoice)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var netValue = _context.Products
                        .Where(p => p.Id == salesInvoice.ProductId)
                        .Select(p => p.ProductUnitPrice.RetailPrice)
                        .FirstOrDefault() ?? 1 * salesInvoice.Quantity;

                    var precentVat = _context.Products
                        .Where(p => p.Id == salesInvoice.ProductId)
                        .Select(p => p.Vatpercentage)
                        .FirstOrDefault();

                    decimal discountValue = salesInvoice.DiscountPercent != 0 ? netValue / salesInvoice.DiscountPercent : 0;

                    decimal vatPercent = precentVat != 0 ? precentVat : 0;
                    decimal vatValue = vatPercent != 0 ? netValue / vatPercent : 0;

                    decimal price = precentVat != 0 ? (netValue - (netValue / precentVat)) * salesInvoice.Quantity : 0;

                    decimal totalValue = (salesInvoice.DiscountPercent != 0 && precentVat != 0) ?
                        (netValue - (netValue / precentVat) - (netValue / salesInvoice.DiscountPercent)) * salesInvoice.Quantity :
                        0;

                    SalesInvoiceDtl salesInvoiceDtl = new SalesInvoiceDtl()
                    {
                        SalesInvoiceHdrId = salesInvoice.SalesInvoiceHdrId,
                        Cost = salesInvoice.Cost,
                        DiscountPercent = salesInvoice.DiscountPercent,
                        DiscountValue = discountValue,
                        IsDeleted = false,
                        ProductId = salesInvoice.ProductId,
                        VatPercent = vatPercent,
                        NetValue = (_context.Products
                            .Where(p => p.Id == salesInvoice.ProductId)
                            .Select(p => p.ProductUnitPrice.RetailPrice)
                            .FirstOrDefault() ?? 1) * salesInvoice.Quantity,
                        Quantity = salesInvoice.Quantity,
                        UnitId = salesInvoice.UnitId,
                        ProductDescription = salesInvoice.ProductDescription,
                        VatValue = vatValue,
                        Price = price,
                        ReturnedQuantity = 0
                    };
                    var salesInvoiceHdr = _context.SalesInvoiceHdrs
                        .Include(s => s.SalesInvoiceDtls)
                        .FirstOrDefault(s => s.Id == salesInvoice.SalesInvoiceHdrId);

                    if (salesInvoiceHdr != null)
                    {
                        salesInvoiceHdr.SalesInvoiceDtls.Add(salesInvoiceDtl);
                    }

                    _context.SaveChanges();

                    // Now, calculate the properties for SalesInvoiceHdr
                    var salesInvoiceDtlSum = _context.SalesInvoiceDtls
                        .Where(d => d.SalesInvoiceHdrId == salesInvoice.SalesInvoiceHdrId)
                        .GroupBy(d => d.SalesInvoiceHdrId)
                        .Select(group => new
                        {
                            OriginalValue = group.Sum(d => d.TotalValue),
                            DiscountValue = group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent),
                            NetValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)),
                            VatPercent = group.Average(d => d.VatPercent), // Average VAT percent of all items
                            VatValue = group.Sum(d => d.VatValue),
                            InvoiceValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)) + group.Sum(d => d.VatValue),
                        })
                        .FirstOrDefault();

                    if (salesInvoiceDtlSum != null)
                    {
                        salesInvoiceHdr.OriginalValue = salesInvoiceDtlSum.OriginalValue;
                        salesInvoiceHdr.DiscountValue = salesInvoiceDtlSum.DiscountValue;
                        salesInvoiceHdr.NetValue = salesInvoiceDtlSum.NetValue;
                        salesInvoiceHdr.VatPercent = salesInvoiceDtlSum.VatPercent;
                        salesInvoiceHdr.VatValue = salesInvoiceDtlSum.VatValue;
                        salesInvoiceHdr.InvoiceValue = salesInvoiceDtlSum.InvoiceValue;
                    }

                    _context.SaveChanges();

                    transaction.Commit();
                    return salesInvoiceDtl;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new ApplicationException($"An error occurred: {ex.Message}");
                }
            }
        }

        public bool DeleteSalesInvoiceDtl(int salesInvoiceHdrId, int productID)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var sales = _context.SalesInvoiceDtls.Where(c => c.SalesInvoiceHdrId == salesInvoiceHdrId)
                                                          .Where(c => c.ProductId == productID)
                                                          .FirstOrDefault();

                    if (sales != null)
                    {
                        SalesInvoiceDtl salesInvoiceDtl = new SalesInvoiceDtl()
                        {
                            SalesInvoiceHdrId = sales.SalesInvoiceHdrId,
                            Cost = sales.Cost,
                            DiscountPercent = sales.DiscountPercent,
                            DiscountValue = sales.DiscountValue,
                            IsDeleted = true,
                            ProductId = sales.ProductId,
                            VatPercent = sales.VatPercent,
                            NetValue = sales.NetValue,
                            Quantity = sales.Quantity,
                            UnitId = sales.UnitId,
                            ProductDescription = sales.ProductDescription,
                            VatValue = sales.VatValue,
                            Price = sales.Price,
                            ReturnedQuantity = sales.Quantity,
                            SalesInvoiceHdr = sales.SalesInvoiceHdr,
                            Product = sales.Product,
                            TotalValue = sales.TotalValue,
                        };

                        _context.SalesInvoiceDtls.Update(salesInvoiceDtl);
                        _context.SaveChanges();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new ApplicationException($"An error occurred: {ex.Message}");
                }
            }
        }

        public SalesInvoiceDtl UpdateSalesInvoiceDtl(int salesInvoiceHdrId, int productID, SalesInvoiceDtlDTO salesInvoice)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var existingSalesInvoiceDtl = _context.SalesInvoiceDtls
                        .Where(c => c.SalesInvoiceHdrId == salesInvoiceHdrId)
                        .Where(c => c.ProductId == productID)
                        .FirstOrDefault();

                    if (existingSalesInvoiceDtl != null)
                    {
                        existingSalesInvoiceDtl.SalesInvoiceHdrId = salesInvoice.SalesInvoiceHdrId;
                        existingSalesInvoiceDtl.Cost = salesInvoice.Cost;
                        existingSalesInvoiceDtl.DiscountPercent = salesInvoice.DiscountPercent;
                        existingSalesInvoiceDtl.ProductId = salesInvoice.ProductId;
                        existingSalesInvoiceDtl.UnitId = salesInvoice.UnitId;
                        existingSalesInvoiceDtl.ProductDescription = salesInvoice.ProductDescription;
                        existingSalesInvoiceDtl.Quantity = salesInvoice.Quantity;

                        // Calculate sums and averages for related sales invoice details
                        var salesInvoiceDtlSum = _context.SalesInvoiceDtls
                            .Where(d => d.SalesInvoiceHdrId == salesInvoiceHdrId)
                            .GroupBy(d => d.SalesInvoiceHdrId)
                            .Select(group => new
                            {
                                OriginalValue = group.Sum(d => d.TotalValue),
                                DiscountValue = group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent),
                                NetValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)),
                                VatPercent = group.Average(d => d.VatPercent), // Average VAT percent of all items
                                VatValue = group.Sum(d => d.VatValue),
                                InvoiceValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)) + group.Sum(d => d.VatValue),
                            })
                            .FirstOrDefault();

                        // Update the properties in the corresponding SalesInvoiceHdr entity
                        if (salesInvoiceDtlSum != null)
                        {
                            var salesInvoiceHdr = _context.SalesInvoiceHdrs
                                .Where(h => h.Id == salesInvoiceHdrId)
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

                        _context.SaveChanges();
                        transaction.Commit();
                        return existingSalesInvoiceDtl;
                    }
                    else
                    {
                        transaction.Rollback();
                        throw new ApplicationException("SalesInvoiceDtl not found.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new ApplicationException($"An error occurred: {ex.Message}");
                }
            }
        }

        public SalesInvoiceDtl ReturnedSalesInvoiceDtl(int salesInvoiceHdrId, int productID, int returnedQuantity, SalesInvoiceDtlDTO salesInvoice)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var existingSalesInvoiceDtl = _context.SalesInvoiceDtls
                        .FirstOrDefault(dtl => dtl.SalesInvoiceHdrId == salesInvoiceHdrId && dtl.ProductId == productID);

                    if (existingSalesInvoiceDtl != null)
                    {
                        if (existingSalesInvoiceDtl.SalesInvoiceHdr.Posted)
                        {
                            transaction.Rollback();
                            throw new ApplicationException("Cannot update a posted record.");
                        }

                        existingSalesInvoiceDtl.DiscountPercent = salesInvoice.DiscountPercent;

                        // Calculate sums and averages for related sales invoice details
                        var salesInvoiceDtlSum = _context.SalesInvoiceDtls
                            .Where(d => d.SalesInvoiceHdrId == salesInvoiceHdrId)
                            .GroupBy(d => d.SalesInvoiceHdrId)
                            .Select(group => new
                            {
                                OriginalValue = group.Sum(d => d.TotalValue),
                                DiscountValue = group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent),
                                NetValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)),
                                VatPercent = group.Average(d => d.VatPercent), // Average VAT percent of all items
                                VatValue = group.Sum(d => d.VatValue),
                                InvoiceValue = group.Sum(d => d.NetValue) - (group.Sum(d => d.TotalValue) - (group.Sum(d => d.TotalValue) / salesInvoice.DiscountPercent)) + group.Sum(d => d.VatValue),
                            })
                            .FirstOrDefault();

                        // Update the properties in the corresponding SalesInvoiceHdr entity
                        if (salesInvoiceDtlSum != null)
                        {
                            var salesInvoiceHdr = _context.SalesInvoiceHdrs
                                .Where(h => h.Id == salesInvoiceHdrId)
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

                        existingSalesInvoiceDtl.ReturnedQuantity = returnedQuantity;

                        _context.SaveChanges();
                        transaction.Commit();
                        return existingSalesInvoiceDtl;
                    }
                    else
                    {
                        transaction.Rollback();
                        throw new ApplicationException("SalesInvoiceDtl not found.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new ApplicationException($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
