using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BackupServers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string Readonly { get; set; }
        public string Immortal { get; set; }
        public string Data { get; set; }
    }
}
