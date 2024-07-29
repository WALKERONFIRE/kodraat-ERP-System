using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class ProductSetting
    {
        public int Id { get; set; }
        public string ProductLength { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
