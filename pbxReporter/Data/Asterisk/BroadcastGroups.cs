using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BroadcastGroups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public int? Update { get; set; }
        public uint? Lastupdate { get; set; }
        public string Csvformat { get; set; }
        public int? Ftpdelete { get; set; }
    }
}
