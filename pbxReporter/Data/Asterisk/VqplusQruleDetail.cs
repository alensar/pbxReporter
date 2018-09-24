using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VqplusQruleDetail
    {
        public int RuleId { get; set; }
        public int Elapsed { get; set; }
        public string MinPenalty { get; set; }
        public string MaxPenalty { get; set; }
    }
}
