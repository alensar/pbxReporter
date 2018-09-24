using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Cronmanager
    {
        public string Module { get; set; }
        public string Id { get; set; }
        public string Time { get; set; }
        public int Freq { get; set; }
        public int Lasttime { get; set; }
        public string Command { get; set; }
    }
}
