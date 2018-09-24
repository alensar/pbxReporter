using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class PagingConfig
    {
        public string PageGroup { get; set; }
        public int ForcePage { get; set; }
        public int Duplex { get; set; }
        public string Description { get; set; }
        public string Announcement { get; set; }
        public int Volume { get; set; }
    }
}
