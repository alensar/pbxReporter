using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BroadcastCallees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phonenum { get; set; }
        public int GroupId { get; set; }
    }
}
