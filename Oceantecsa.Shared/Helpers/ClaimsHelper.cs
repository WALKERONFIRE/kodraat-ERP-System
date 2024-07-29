using Microsoft.AspNetCore.Http;
using Oceantecsa.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers
{
    public class ClaimsHelper
    {
        public UserClaimsDTO User { get; set; }
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClaimsHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            User = GetUserFromClaims(_httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity);
        }

        public static UserClaimsDTO GetUserFromClaims(ClaimsIdentity identity)
        {
            if (identity == null) return null;
            var userAccount = new UserClaimsDTO
            {
                UserId = GetClaim(identity, "userid"),
                UserName = GetClaim(identity, "preferred_username")
                ,
                UserInfo = GetClaim(identity, "UserInfo")
            };
            return userAccount;
        }

        public static string GetClaim(ClaimsIdentity identity, string type)
        {
            return identity.Claims.Where(c => c.Type == type).Select(c => c.Value).FirstOrDefault();
        }
    }
}
