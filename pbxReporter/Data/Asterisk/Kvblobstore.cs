using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Kvblobstore
    {
        public string Uuid { get; set; }
        public string Type { get; set; }
        public byte[] Content { get; set; }
    }
}
