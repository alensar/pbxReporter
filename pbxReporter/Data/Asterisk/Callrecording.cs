using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Callrecording
    {
        public int CallrecordingId { get; set; }
        public string CallrecordingMode { get; set; }
        public string Description { get; set; }
        public string Dest { get; set; }
    }
}
