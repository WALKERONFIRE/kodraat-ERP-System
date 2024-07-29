using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrRecApplicationQues1
    {
        public int FId { get; set; }
        public int JobApplicationId { get; set; }
        public int QuestinId { get; set; }
        public bool Result { get; set; }
        public string FDesc { get; set; } = null!;

        public virtual HrRecJobApplication JobApplication { get; set; } = null!;
        public virtual HrRecApplicationQuestion Questin { get; set; } = null!;
    }
}
