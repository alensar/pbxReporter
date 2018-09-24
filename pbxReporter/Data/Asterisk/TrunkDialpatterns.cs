using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class TrunkDialpatterns
    {
        public int Trunkid { get; set; }
        public string MatchPatternPrefix { get; set; }
        public string MatchPatternPass { get; set; }
        public string PrependDigits { get; set; }
        public int Seq { get; set; }
    }
}
