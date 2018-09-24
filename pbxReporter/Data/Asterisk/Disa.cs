using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Disa
    {
        public int DisaId { get; set; }
        public string Displayname { get; set; }
        public string Pin { get; set; }
        public string Cid { get; set; }
        public string Context { get; set; }
        public int? Digittimeout { get; set; }
        public int? Resptimeout { get; set; }
        public string Needconf { get; set; }
        public string Hangup { get; set; }
        public sbyte Keepcid { get; set; }
    }
}
