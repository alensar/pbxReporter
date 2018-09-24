using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Ringgroups
    {
        public string Grpnum { get; set; }
        public string Strategy { get; set; }
        public short Grptime { get; set; }
        public string Grppre { get; set; }
        public string Grplist { get; set; }
        public int? AnnmsgId { get; set; }
        public string Postdest { get; set; }
        public string Description { get; set; }
        public string Alertinfo { get; set; }
        public int? RemotealertId { get; set; }
        public string Needsconf { get; set; }
        public int? ToolateId { get; set; }
        public string Ringing { get; set; }
        public string Cwignore { get; set; }
        public string Cfignore { get; set; }
        public string Cpickup { get; set; }
        public string Recording { get; set; }
        public string Progress { get; set; }
        public string Elsewhere { get; set; }
        public string Rvolume { get; set; }
    }
}
