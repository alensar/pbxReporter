using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class UcpSessions
    {
        public string Session { get; set; }
        public int? Uid { get; set; }
        public string Address { get; set; }
        public int? Time { get; set; }
        public string Socketid { get; set; }
    }
}
