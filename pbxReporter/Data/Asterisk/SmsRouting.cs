using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SmsRouting
    {
        public int Id { get; set; }
        public string Did { get; set; }
        public int Uid { get; set; }
        public string Accepter { get; set; }
        public string Adaptor { get; set; }
        public int Didid { get; set; }
    }
}
