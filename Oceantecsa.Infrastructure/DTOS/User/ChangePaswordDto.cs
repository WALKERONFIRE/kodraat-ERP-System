﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS.User
{
    public partial class ChangePaswordDto
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}