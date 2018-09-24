using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CertmanCas
    {
        public int Uid { get; set; }
        public string Basename { get; set; }
        public string Cn { get; set; }
        public string On { get; set; }
        public string Passphrase { get; set; }
        public string Salt { get; set; }
    }
}
