using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Queueprio
    {
        public int QueueprioId { get; set; }
        public string QueuePriority { get; set; }
        public string Description { get; set; }
        public string Dest { get; set; }
    }
}
