using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Description { get; set; }
        public int? RecordingId { get; set; }
        public int? AllowSkip { get; set; }
        public string PostDest { get; set; }
        public sbyte ReturnIvr { get; set; }
        public sbyte Noanswer { get; set; }
        public string RepeatMsg { get; set; }
    }
}
