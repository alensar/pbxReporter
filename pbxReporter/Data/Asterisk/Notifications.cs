using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Notifications
    {
        public string Module { get; set; }
        public string Id { get; set; }
        public int Level { get; set; }
        public string DisplayText { get; set; }
        public byte[] ExtendedText { get; set; }
        public string Link { get; set; }
        public sbyte Reset { get; set; }
        public sbyte Candelete { get; set; }
        public int Timestamp { get; set; }
    }
}
