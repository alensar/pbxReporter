using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Pagingpro
    {
        public string PageId { get; set; }
        public string Busypage { get; set; }
        public string IntroRecording { get; set; }
        public string CidPrepend { get; set; }
        public string Timezone { get; set; }
        public sbyte? Autoanswer { get; set; }
        public sbyte? EnableScheduler { get; set; }
        public sbyte? EnableCalendar { get; set; }
        public string CalendarId { get; set; }
        public string CalendarGroupId { get; set; }
    }
}
