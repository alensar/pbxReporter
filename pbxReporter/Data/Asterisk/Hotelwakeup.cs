using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Hotelwakeup
    {
        public int Maxretries { get; set; }
        public int Waittime { get; set; }
        public int Retrytime { get; set; }
        public int Extensionlength { get; set; }
        public string Cid { get; set; }
        public string Cnam { get; set; }
        public int OperatorMode { get; set; }
        public string OperatorExtensions { get; set; }
        public string Application { get; set; }
        public string Data { get; set; }
    }
}
