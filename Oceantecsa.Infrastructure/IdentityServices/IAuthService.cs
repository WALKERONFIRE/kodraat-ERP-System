using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public interface IAuthService
    {
        Task<(bool, string)> Login(LoginDto loginDto);

    }
}
