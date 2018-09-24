using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CertmanCerts
    {
        public int Cid { get; set; }
        public int? Caid { get; set; }
        public string Basename { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public sbyte Default { get; set; }
        public byte[] Additional { get; set; }
    }
}
