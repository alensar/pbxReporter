using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VqplusCallbackCalls
    {
        public string Uniqueid { get; set; }
        public string QueueNum { get; set; }
        public int Cbid { get; set; }
        public int Position { get; set; }
        public string Callback { get; set; }
    }
}
