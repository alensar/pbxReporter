using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Modules
    {
        public int Id { get; set; }
        public string Modulename { get; set; }
        public string Version { get; set; }
        public sbyte Enabled { get; set; }
        public byte[] Signature { get; set; }
    }
}
