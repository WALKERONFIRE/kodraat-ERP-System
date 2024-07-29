﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class ModuleAccountsDtlDto
    {
        public string EnglishName { get; set; }
        public string ArabicName { get; set; } 
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
