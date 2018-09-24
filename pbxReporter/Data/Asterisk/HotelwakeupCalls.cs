using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class HotelwakeupCalls
    {
        public int Time { get; set; }
        public int Ext { get; set; }
        public int Maxretries { get; set; }
        public int Retrytime { get; set; }
        public int Waittime { get; set; }
        public string Cid { get; set; }
        public string Cnam { get; set; }
        public string Application { get; set; }
        public string Data { get; set; }
        public string Tempdir { get; set; }
        public string Outdir { get; set; }
        public string Filename { get; set; }
        public int Frequency { get; set; }
    }
}
