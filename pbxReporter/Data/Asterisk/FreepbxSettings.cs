using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class FreepbxSettings
    {
        public string Keyword { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public sbyte? Level { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Options { get; set; }
        public string Defaultval { get; set; }
        public sbyte? Readonly { get; set; }
        public sbyte? Hidden { get; set; }
        public string Category { get; set; }
        public string Module { get; set; }
        public sbyte? Emptyok { get; set; }
        public int? Sortorder { get; set; }
    }
}
