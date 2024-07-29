using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
    public class UserClaimsDTO
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserInfo { get; set; }

    }

    public class UserInfoDTO
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public int? Statusid { get; set; }
        public int? Groupid { get; set; }
        public DateTime? Lastlogintime { get; set; }
        public int? Kadiid { get; set; }
        public int? UigId { get; set; }
        public double? Userprepaid { get; set; }
        public double? Userdiscount { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? CommissionPercent { get; set; }
        public int? EmployeeId { get; set; }
        public int? BranchId { get; set; }
        public bool? Play { get; set; }
        public string FullName { get; set; }
        public int? Lang { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
