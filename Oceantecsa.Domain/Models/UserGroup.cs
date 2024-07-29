using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            UserGroupPermissions = new HashSet<UserGroupPermission>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
