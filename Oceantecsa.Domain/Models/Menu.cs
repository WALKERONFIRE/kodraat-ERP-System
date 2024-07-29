using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Menu
    {
        public Menu()
        {
            UserGroupPermissions = new HashSet<UserGroupPermission>();
        }

        public long Id { get; set; }
        public long ParentId { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PageUrl { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; }
    }
}
