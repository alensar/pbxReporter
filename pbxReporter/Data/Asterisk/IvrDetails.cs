using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class IvrDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Announcement { get; set; }
        public string Directdial { get; set; }
        public string InvalidLoops { get; set; }
        public string InvalidRetryRecording { get; set; }
        public string InvalidDestination { get; set; }
        public string TimeoutEnabled { get; set; }
        public string InvalidRecording { get; set; }
        public string Retvm { get; set; }
        public int? TimeoutTime { get; set; }
        public string TimeoutRecording { get; set; }
        public string TimeoutRetryRecording { get; set; }
        public string TimeoutDestination { get; set; }
        public string TimeoutLoops { get; set; }
        public sbyte TimeoutAppendAnnounce { get; set; }
        public sbyte InvalidAppendAnnounce { get; set; }
        public sbyte TimeoutIvrRet { get; set; }
        public sbyte InvalidIvrRet { get; set; }
        public string Alertinfo { get; set; }
        public string Rvolume { get; set; }
    }
}
