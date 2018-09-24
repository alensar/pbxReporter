using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Featurecodes
    {
        public string Modulename { get; set; }
        public string Featurename { get; set; }
        public string Description { get; set; }
        public string Helptext { get; set; }
        public string Defaultcode { get; set; }
        public string Customcode { get; set; }
        public sbyte Enabled { get; set; }
        public sbyte Providedest { get; set; }
    }
}
