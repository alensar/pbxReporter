using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CertmanMapping
    {
        public string Id { get; set; }
        public int? Cid { get; set; }
        public string Verify { get; set; }
        public string Setup { get; set; }
        public int? Rekey { get; set; }
    }
}
