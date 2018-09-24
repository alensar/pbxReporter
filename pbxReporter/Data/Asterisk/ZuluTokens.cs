using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ZuluTokens
    {
        public int Uid { get; set; }
        public string Token { get; set; }
        public string Client { get; set; }
        public int? Connecttime { get; set; }
    }
}
