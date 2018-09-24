using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class QueuesConfig
    {
        public string Extension { get; set; }
        public string Descr { get; set; }
        public string Grppre { get; set; }
        public string Alertinfo { get; set; }
        public sbyte Ringing { get; set; }
        public string Maxwait { get; set; }
        public string Password { get; set; }
        public string IvrId { get; set; }
        public string Dest { get; set; }
        public sbyte Cwignore { get; set; }
        public sbyte? Queuewait { get; set; }
        public sbyte? UseQueueContext { get; set; }
        public sbyte? Togglehint { get; set; }
        public sbyte? Qnoanswer { get; set; }
        public sbyte? Callconfirm { get; set; }
        public int? CallconfirmId { get; set; }
        public string Qregex { get; set; }
        public int? AgentannounceId { get; set; }
        public int? JoinannounceId { get; set; }
        public string MonitorType { get; set; }
        public int? MonitorHeard { get; set; }
        public int? MonitorSpoken { get; set; }
        public string CallbackId { get; set; }
    }
}
