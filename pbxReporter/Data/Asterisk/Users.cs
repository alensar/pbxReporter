using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Users
    {
        public string Extension { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Voicemail { get; set; }
        public int? Ringtimer { get; set; }
        public string Noanswer { get; set; }
        public string Recording { get; set; }
        public string Outboundcid { get; set; }
        public string Sipname { get; set; }
        public string NoanswerCid { get; set; }
        public string BusyCid { get; set; }
        public string ChanunavailCid { get; set; }
        public string NoanswerDest { get; set; }
        public string BusyDest { get; set; }
        public string ChanunavailDest { get; set; }
        public string Mohclass { get; set; }
    }
}
