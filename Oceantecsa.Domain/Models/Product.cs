using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductProperties = new HashSet<ProductProperty>();
            ProductUnitPrices = new HashSet<ProductUnitPrice>();
            PurchaseInvoiceDtls = new HashSet<PurchaseInvoiceDtl>();
            PurchaseReturnDtls = new HashSet<PurchaseReturnDtl>();
            SalesInvoiceDtls = new HashSet<SalesInvoiceDtl>();
            TransactionInDtls = new HashSet<TransactionInDtl>();
            TransactionOutDtls = new HashSet<TransactionOutDtl>();
        }

        public long Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductProductionTypeId { get; set; }
        public int MeasurementUnitId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierProductId { get; set; } = null!;
        public int VattypeId { get; set; }
        public decimal Vatpercentage { get; set; }
        public decimal SalesTaxPercent { get; set; }
        public decimal SafetyPoint { get; set; }
        public decimal ReorderPoint { get; set; }
        public bool HasExpiryDate { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int ManufacturingCountryId { get; set; }
        public long AlternativeProduct { get; set; }
        public decimal MaxReorderPoint { get; set; }
        public decimal ProductHeight { get; set; }
        public decimal ProductWidth { get; set; }
        public string Photo { get; set; } = null!;
        public string? Barcode { get; set; }
        public int? ProductUnitPriceId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; } = null!;
        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual ProductProductionType ProductProductionType { get; set; } = null!;
        public virtual ProductType ProductType { get; set; } = null!;
        public virtual ProductUnitPrice? ProductUnitPrice { get; set; }
        public virtual Vattype Vattype { get; set; } = null!;
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
        public virtual ICollection<ProductUnitPrice> ProductUnitPrices { get; set; }
        public virtual ICollection<PurchaseInvoiceDtl> PurchaseInvoiceDtls { get; set; }
        public virtual ICollection<PurchaseReturnDtl> PurchaseReturnDtls { get; set; }
        public virtual ICollection<SalesInvoiceDtl> SalesInvoiceDtls { get; set; }
        public virtual ICollection<TransactionInDtl> TransactionInDtls { get; set; }
        public virtual ICollection<TransactionOutDtl> TransactionOutDtls { get; set; }
    }
}
