using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CalleridEntries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Cidname { get; set; }
        public string Cidnum { get; set; }
        public string Perm { get; set; }
    }
}
