using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Vmnotify
    {
        public string Mailbox { get; set; }
        public string Recipients { get; set; }
        public string Outcid { get; set; }
        public string Outcidname { get; set; }
        public string Cidtype { get; set; }
        public string Deletemsg { get; set; }
        public byte Getname { get; set; }
        public ushort Retrycount { get; set; }
        public ushort Retrydelay { get; set; }
        public ushort Prioritydelay { get; set; }
        public string Emailsuccess { get; set; }
        public string Emailfail { get; set; }
        public string Emailfrom { get; set; }
        public string Emailsubject { get; set; }
        public string Emailbody { get; set; }
        public sbyte Emailattach { get; set; }
        public sbyte Enabled { get; set; }
        public uint Greetingid { get; set; }
        public uint Instructionsid { get; set; }
    }
}
