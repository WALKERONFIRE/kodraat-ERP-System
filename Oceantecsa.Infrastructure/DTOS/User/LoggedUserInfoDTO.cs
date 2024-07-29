using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS.User
{
    public class LoggedUserInfoDTO
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public int? Groupid { get; set; }
        public int? BranchId { get; set; }
        public string Lang { get; set; }
        public double? Userdiscount { get; set; }
        public decimal? DiscountValue { get; set; }
        public int? Statusid { get; set; }
        public DateTime? Lastlogintime { get; set; }
        public int? Kadiid { get; set; }
        public List<string> UserModules { get; set; }
        public List<UserPrivilegePageDto> UserPrivilegePage { get; set; }


    }
    public class UserPrivilegePageDto
    {
        public int pageID { get; set; }
        public bool newFunction { get; set; }
        public bool editFunction { get; set; }
        public bool saveFunction { get; set; }
        public bool postFunction { get; set; }
        public bool deleteFunction { get; set; }
        public bool cancelFunction { get; set; }
        public bool searchFunction { get; set; }
        public bool printFunction { get; set; }
        public bool rejectFunction { get; set; }
    }
}
