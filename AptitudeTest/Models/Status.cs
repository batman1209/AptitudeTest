using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class Status
    {
        public Status()
        {
            PaperInfo = new HashSet<PaperInfo>();
        }

        public int StatusId { get; set; }
        public string CurrentStatus { get; set; }

        public virtual ICollection<PaperInfo> PaperInfo { get; set; }
    }
}
