using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VmnotifyNotifications
    {
        public uint Id { get; set; }
        public string Mailbox { get; set; }
        public sbyte Status { get; set; }
        public int Retry { get; set; }
        public int Priority { get; set; }
        public uint? Time { get; set; }
        public string Callerid { get; set; }
        public uint Length { get; set; }
    }
}
