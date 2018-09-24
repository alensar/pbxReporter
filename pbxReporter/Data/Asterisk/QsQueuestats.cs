using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QsQueuestats
    {
        public long Id { get; set; }
        public string Serverid { get; set; }
        public string Queuename { get; set; }
        public int Incomingcalls { get; set; }
        public int Answeredcalls { get; set; }
        public int Abandoned { get; set; }
        public int Ivrabandoned { get; set; }
        public int Shortestholdsec { get; set; }
        public string Shortestholdid { get; set; }
        public int Longestholdsec { get; set; }
        public string Longestholdid { get; set; }
        public int Totalagents { get; set; }
        public int Agentsavail { get; set; }
        public int Agentsunavail { get; set; }
        public int Agentsinuse { get; set; }
        public int Callswaiting { get; set; }
        public int Periodstart { get; set; }
        public int Periodend { get; set; }
        public int Activecalls { get; set; }
        public int Completedcalls { get; set; }
        public int Averageholdsec { get; set; }
        public int Shortesttalksec { get; set; }
        public string Shortesttalkid { get; set; }
        public int Averagetalksec { get; set; }
        public int Longesttalksec { get; set; }
        public string Longesttalkid { get; set; }
        public decimal Slapercent { get; set; }
    }
}
