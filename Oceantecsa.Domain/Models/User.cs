using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class User
    {
        public User()
        {
            UserBankAccounts = new HashSet<UserBankAccount>();
            UserBranches = new HashSet<UserBranch>();
            UserCashBoxes = new HashSet<UserCashBox>();
            UserWarehouses = new HashSet<UserWarehouse>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public int UserGroupId { get; set; }
        public int Language { get; set; }
        public decimal PrepaidValue { get; set; }
        public bool Salesman { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public decimal PrepaidPercent { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal CommissionPercent { get; set; }
        public bool BranchManager { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual UserGroup UserGroup { get; set; } = null!;
        public virtual ICollection<UserBankAccount> UserBankAccounts { get; set; }
        public virtual ICollection<UserBranch> UserBranches { get; set; }
        public virtual ICollection<UserCashBox> UserCashBoxes { get; set; }
        public virtual ICollection<UserWarehouse> UserWarehouses { get; set; }
    }
}
