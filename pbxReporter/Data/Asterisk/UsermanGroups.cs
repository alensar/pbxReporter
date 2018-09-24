using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class UsermanGroups
    {
        public int Id { get; set; }
        public string Auth { get; set; }
        public string Authid { get; set; }
        public string Groupname { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string Timezone { get; set; }
        public string Dateformat { get; set; }
        public string Timeformat { get; set; }
        public string Datetimeformat { get; set; }
        public int Priority { get; set; }
        public byte[] Users { get; set; }
        public byte[] Permissions { get; set; }
        public int Local { get; set; }
    }
}
