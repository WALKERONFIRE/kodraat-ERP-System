using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishAddress { get; set; } = null!;
        public string ArabicAddress { get; set; } = null!;
        public string TelephoneNo1 { get; set; } = null!;
        public string TelephoneNo2 { get; set; } = null!;
        public string TelephoneNo3 { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[]? LargeLogo { get; set; }
        public byte[]? SmallLogo { get; set; }
        public string CommercialRegisterNo { get; set; } = null!;
        public string CardImportNo { get; set; } = null!;
        public string CardExportNo { get; set; } = null!;
        public string UniqueNo { get; set; } = null!;
        public string WebSite { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FacebookPage { get; set; } = null!;
        public string YoutubeChannel { get; set; } = null!;
        public string InstagramAccount { get; set; } = null!;
        public string TwitterAccount { get; set; } = null!;
        public string SnapChatAccount { get; set; } = null!;
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public bool? Active { get; set; }
        public bool IsDeleted { get; set; }
        public int CountryId { get; set; }
        public int CompanyTypeId { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Shareholders { get; set; } = null!;
        public decimal Capital { get; set; }
        public string GeneralTaxNo { get; set; } = null!;
        public string SalesTaxNo { get; set; } = null!;
        public string ValueAddedTaxNo { get; set; } = null!;
    }
}
