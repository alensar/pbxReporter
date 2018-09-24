using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Ampusers
    {
        public string Username { get; set; }
        public string PasswordSha1 { get; set; }
        public string ExtensionLow { get; set; }
        public string ExtensionHigh { get; set; }
        public string Deptname { get; set; }
        public byte[] Sections { get; set; }
    }
}
