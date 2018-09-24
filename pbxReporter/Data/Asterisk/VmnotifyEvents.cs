using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VmnotifyEvents
    {
        public uint Id { get; set; }
        public uint NotificationId { get; set; }
        public uint? Time { get; set; }
        public string Number { get; set; }
        public int Priority { get; set; }
        public sbyte Status { get; set; }
    }
}
