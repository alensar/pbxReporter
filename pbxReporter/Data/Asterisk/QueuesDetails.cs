using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QueuesDetails
    {
        public string Id { get; set; }
        public string Keyword { get; set; }
        public string Data { get; set; }
        public int Flags { get; set; }
    }
}
