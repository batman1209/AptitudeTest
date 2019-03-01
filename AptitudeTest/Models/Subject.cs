using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Question = new HashSet<Question>();
        }

        public int SubjectId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
