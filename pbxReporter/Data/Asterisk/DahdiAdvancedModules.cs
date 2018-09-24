using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DahdiAdvancedModules
    {
        public uint Id { get; set; }
        public string ModuleName { get; set; }
        public byte[] Settings { get; set; }
    }
}
