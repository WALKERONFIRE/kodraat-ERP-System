using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Division
    {
        public Division()
        {
            Shelves = new HashSet<Shelf>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int LocationId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Location Location { get; set; } = null!;
        public virtual ICollection<Shelf> Shelves { get; set; }
    }
}
