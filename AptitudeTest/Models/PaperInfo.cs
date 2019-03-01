using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class PaperInfo
    {
        public int PaperId { get; set; }
        public int? Year { get; set; }
        public string Shift { get; set; }
        public string Final { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
    }
}
