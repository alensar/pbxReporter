using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QsCallstats
    {
        public string Callid { get; set; }
        public string Serverid { get; set; }
        public string Did { get; set; }
        public string Callerid { get; set; }
        public string Queuename { get; set; }
        public int Entryposition { get; set; }
        public int Entrytime { get; set; }
        public int Holdtime { get; set; }
        public int Talktime { get; set; }
        public string Status { get; set; }
        public sbyte Complete { get; set; }
        public string Agentname { get; set; }
        public string Lastevent { get; set; }
        public int Lasteventtime { get; set; }
        public int Lasteventid { get; set; }
        public string Relatedcallid { get; set; }
        public int Answertime { get; set; }
        public int Completetime { get; set; }
    }
}
