using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SmsMedia
    {
        public int Id { get; set; }
        public int Mid { get; set; }
        public string Name { get; set; }
        public byte[] Raw { get; set; }
    }
}
