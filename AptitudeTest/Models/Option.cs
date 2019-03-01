﻿using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class Option
    {
        public int OptionId { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public int QuesId { get; set; }
        public string CorrectOption { get; set; }

        public virtual Question Ques { get; set; }
    }
}
