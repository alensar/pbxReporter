using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VqplusCallbackConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cid { get; set; }
        public string Numprepend { get; set; }
        public string Patterns { get; set; }
        public string Announcement { get; set; }
        public sbyte? Forcecid { get; set; }
        public string Cbdfcountry { get; set; }
        public string Cbstarttime { get; set; }
        public string Cbendtime { get; set; }
        public sbyte? Cbtiming { get; set; }
        public sbyte? Recordname { get; set; }
        public string Promptreqnum { get; set; }
        public string Promptreqname { get; set; }
        public string Promptreqconfirm { get; set; }
        public string Promptcb { get; set; }
        public string Promptcbaccept { get; set; }
        public string Cbqueue { get; set; }
        public int? Timeout { get; set; }
        public int? Retries { get; set; }
        public int? Retrydelay { get; set; }
        public int? Maxcallbacks { get; set; }
    }
}
