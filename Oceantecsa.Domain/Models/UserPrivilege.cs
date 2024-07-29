using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class UserPrivilege
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public long MenuId { get; set; }
        public bool NewFunction { get; set; }
        public bool EditFunction { get; set; }
        public bool SaveFunction { get; set; }
        public bool PostFunction { get; set; }
        public bool DeleteFunction { get; set; }
        public bool CancelFunction { get; set; }
        public bool SearchFunction { get; set; }
        public bool PrintFunction { get; set; }
        public bool RejectFunction { get; set; }
    }
}
