using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class FreepbxLog
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Section { get; set; }
        public string Level { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
