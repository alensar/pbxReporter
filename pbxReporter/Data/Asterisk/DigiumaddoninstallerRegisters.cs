using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DigiumaddoninstallerRegisters
    {
        public uint Id { get; set; }
        public string AddonId { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }
        public string Data { get; set; }
        public DateTime TimeRegistered { get; set; }
    }
}
