using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CountryId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<City> Cities { get; set; }
    }
}
