using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class UsermanDirectories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Driver { get; set; }
        public sbyte Active { get; set; }
        public int Order { get; set; }
        public sbyte Default { get; set; }
        public sbyte Locked { get; set; }
    }
}
