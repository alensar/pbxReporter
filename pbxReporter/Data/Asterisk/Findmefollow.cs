using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Findmefollow
    {
        public string Grpnum { get; set; }
        public string Strategy { get; set; }
        public short Grptime { get; set; }
        public string Grppre { get; set; }
        public string Grplist { get; set; }
        public int? AnnmsgId { get; set; }
        public string Postdest { get; set; }
        public string Dring { get; set; }
        public string Rvolume { get; set; }
        public int? RemotealertId { get; set; }
        public string Needsconf { get; set; }
        public int? ToolateId { get; set; }
        public short PreRing { get; set; }
        public string Ringing { get; set; }
        public sbyte? CalendarEnable { get; set; }
        public string CalendarId { get; set; }
        public string CalendarGroupId { get; set; }
        public string CalendarMatch { get; set; }
    }
}
