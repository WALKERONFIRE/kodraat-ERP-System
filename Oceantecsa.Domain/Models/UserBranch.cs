using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserBranch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public bool Bind { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
