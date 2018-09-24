using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Timeconditions
    {
        public int TimeconditionsId { get; set; }
        public string Displayname { get; set; }
        public int? Time { get; set; }
        public string Truegoto { get; set; }
        public string Falsegoto { get; set; }
        public string Deptname { get; set; }
        public sbyte? GenerateHint { get; set; }
        public sbyte? InvertHint { get; set; }
        public string FccPassword { get; set; }
        public string Priority { get; set; }
        public string Timezone { get; set; }
        public string Mode { get; set; }
        public string CalendarId { get; set; }
        public string CalendarGroupId { get; set; }
    }
}
