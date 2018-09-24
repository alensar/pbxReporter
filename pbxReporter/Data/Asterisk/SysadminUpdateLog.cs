using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SysadminUpdateLog
    {
        public int Id { get; set; }
        public long? Time { get; set; }
        public string Version { get; set; }
        public short? StatusId { get; set; }
        public string Status { get; set; }
    }
}
