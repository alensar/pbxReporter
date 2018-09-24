using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SuperfectaMfChild
    {
        public long SuperfectaMfChildId { get; set; }
        public long? SuperfectaMfId { get; set; }
        public int? Priority { get; set; }
        public string Source { get; set; }
        public double? TimestampStart { get; set; }
        public double? TimestampCnam { get; set; }
        public double? TimestampEnd { get; set; }
        public int? Spam { get; set; }
        public string SpamText { get; set; }
        public string Cnam { get; set; }
        public sbyte? Cached { get; set; }
        public string DebugResult { get; set; }
        public string ErrorResult { get; set; }
    }
}
