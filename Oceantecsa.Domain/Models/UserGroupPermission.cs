using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserGroupPermission
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public long MenuId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Menu Menu { get; set; } = null!;
        public virtual UserGroup UserGroup { get; set; } = null!;
    }
}
