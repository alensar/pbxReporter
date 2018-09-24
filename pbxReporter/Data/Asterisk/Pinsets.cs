using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Pinsets
    {
        public int PinsetsId { get; set; }
        public string Passwords { get; set; }
        public string Description { get; set; }
        public sbyte? Addtocdr { get; set; }
        public string Deptname { get; set; }
    }
}
