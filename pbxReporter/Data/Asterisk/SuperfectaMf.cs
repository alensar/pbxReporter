using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SuperfectaMf
    {
        public long SuperfectaMfId { get; set; }
        public double? TimestampStart { get; set; }
        public double? TimestampEnd { get; set; }
        public string Scheme { get; set; }
        public string Cidnum { get; set; }
        public string Extension { get; set; }
        public string Prefix { get; set; }
        public sbyte? Debug { get; set; }
        public long? WinningChildId { get; set; }
        public long? SpamChildId { get; set; }
    }
}
