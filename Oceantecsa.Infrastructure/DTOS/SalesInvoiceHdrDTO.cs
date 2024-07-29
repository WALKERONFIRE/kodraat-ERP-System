﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class SalesInvoiceHdrDTO
    {
        public long SalesInvoiceId { get; set; }
        public int TypeId { get; set; }
        public int SalesCashTypeId { get; set; }
        public int BranchId { get; set; }
        public int WarehouseId { get; set; }
        public int LocationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDescription { get; set; } = null!;
        //public decimal OriginalValue { get; set; }
        public decimal DiscountPercent { get; set; }
        //public decimal DiscountValue { get; set; }
        //public decimal NetValue { get; set; }
        //public decimal VatPercent { get; set; }
        //public decimal VatValue { get; set; }
        //public decimal InvoiceValue { get; set; }
        public decimal PaidValue { get; set; }
        public long JournalId { get; set; }
        public int GroupOfferId { get; set; }
        public int ItemOfferId { get; set; }
        public int SpecialOfferId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
    }
}