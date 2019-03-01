using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class DifficultyLevel
    {
        public DifficultyLevel()
        {
            Question = new HashSet<Question>();
        }

        public int DifficultyId { get; set; }
        public string DiffLevel { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
