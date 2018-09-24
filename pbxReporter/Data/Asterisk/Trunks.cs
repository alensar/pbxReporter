using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Trunks
    {
        public int Trunkid { get; set; }
        public string Tech { get; set; }
        public string Channelid { get; set; }
        public string Name { get; set; }
        public string Outcid { get; set; }
        public string Keepcid { get; set; }
        public string Maxchans { get; set; }
        public string Failscript { get; set; }
        public string Dialoutprefix { get; set; }
        public string Usercontext { get; set; }
        public string Provider { get; set; }
        public string Disabled { get; set; }
        public string Continue { get; set; }
    }
}
