using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VqplusCallbackLog
    {
        public string Uniqueid { get; set; }
        public int Timestamp { get; set; }
        public string QueueNum { get; set; }
        public int Cbid { get; set; }
        public string Callback { get; set; }
        public sbyte? Success { get; set; }
        public string Reason { get; set; }
    }
}
