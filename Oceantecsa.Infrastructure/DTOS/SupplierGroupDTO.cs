﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class SupplierGroupDTO
    {
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public long MainAccountId { get; set; }
        public string Description { get; set; } = null!;

    }
}