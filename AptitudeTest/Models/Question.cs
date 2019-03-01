using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class Question
    {
        public Question()
        {
            Option = new HashSet<Option>();
        }

        public int QuesId { get; set; }
        public string QuestionStatement { get; set; }
        public int DifficultyId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public virtual DifficultyLevel Difficulty { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Option> Option { get; set; }
    }
}
