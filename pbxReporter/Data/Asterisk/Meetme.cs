using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Meetme
    {
        public string Exten { get; set; }
        public string Options { get; set; }
        public string Userpin { get; set; }
        public string Adminpin { get; set; }
        public string Description { get; set; }
        public int? JoinmsgId { get; set; }
        public string Music { get; set; }
        public ushort? Users { get; set; }
        public string Language { get; set; }
        public uint? Timeout { get; set; }
    }
}
