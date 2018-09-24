using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SmsMessages
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Threadid { get; set; }
        public string Cnam { get; set; }
        public string Direction { get; set; }
        public DateTime TxRxDatetime { get; set; }
        public string Body { get; set; }
        public sbyte Delivered { get; set; }
        public sbyte Read { get; set; }
        public string Adaptor { get; set; }
        public string Emid { get; set; }
        public int Didid { get; set; }
        public int Timestamp { get; set; }
    }
}
