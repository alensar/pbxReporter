using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ModuleXml
    {
        public string Id { get; set; }
        public int Time { get; set; }
        public byte[] Data { get; set; }
    }
}
