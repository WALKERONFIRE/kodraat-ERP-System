using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Collector
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool IsEmployee { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string EnglishAddress { get; set; } = null!;
        public string ArabicAddress { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public double Percentage { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
