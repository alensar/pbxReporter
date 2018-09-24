using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class FaxStore
    {
        public string Faxid { get; set; }
        public string User { get; set; }
        public string Dir { get; set; }
        public string Date { get; set; }
        public string Header { get; set; }
        public string Stationid { get; set; }
        public string Callid { get; set; }
        public string Dest { get; set; }
        public string Status { get; set; }
        public string Pages { get; set; }
        public string File { get; set; }
        public string New { get; set; }
        public string Finished { get; set; }
        public int? Pid { get; set; }
        public string Channel { get; set; }
    }
}
