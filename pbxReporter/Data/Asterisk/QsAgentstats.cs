using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QsAgentstats
    {
        public long Id { get; set; }
        public string Serverid { get; set; }
        public int Statstart { get; set; }
        public int Statend { get; set; }
        public string Agentid { get; set; }
        public int Missedcalls { get; set; }
        public int Answeredcalls { get; set; }
        public int Avgtalktime { get; set; }
        public int Mintalktime { get; set; }
        public string Mintalkcallid { get; set; }
        public int Maxtalktime { get; set; }
        public string Maxtalkcallid { get; set; }
        public int Completedcalls { get; set; }
        public int Pausedsec { get; set; }
        public int Idlesec { get; set; }
        public int Talksec { get; set; }
        public int Wrapupsec { get; set; }
    }
}
