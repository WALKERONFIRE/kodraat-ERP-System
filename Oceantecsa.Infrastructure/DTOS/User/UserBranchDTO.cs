using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS.User
{
    public class UserBranchDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public bool Bind { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }


    }
}
