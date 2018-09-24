using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DirectoryDetails
    {
        public int Id { get; set; }
        public string Dirname { get; set; }
        public string Description { get; set; }
        public int? Announcement { get; set; }
        public string CallidPrefix { get; set; }
        public string AlertInfo { get; set; }
        public string Rvolume { get; set; }
        public string RepeatLoops { get; set; }
        public int? RepeatRecording { get; set; }
        public int? InvalidRecording { get; set; }
        public string InvalidDestination { get; set; }
        public string Retivr { get; set; }
        public string SayExtension { get; set; }
    }
}
