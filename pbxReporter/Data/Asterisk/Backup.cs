using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Backup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Immortal { get; set; }
        public string Data { get; set; }
        public string Email { get; set; }
    }
}
