using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserBankAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BanckAccountId { get; set; }
        public bool Bind { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual BankAccount BanckAccount { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
