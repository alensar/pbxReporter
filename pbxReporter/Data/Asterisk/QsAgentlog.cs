using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QsAgentlog
    {
        public long Id { get; set; }
        public string Serverid { get; set; }
        public string Agentid { get; set; }
        public string Event { get; set; }
        public string Queuename { get; set; }
        public int Eventstart { get; set; }
        public int Eventend { get; set; }
        public int Eventlength { get; set; }
        public string Eventdata { get; set; }
    }
}
