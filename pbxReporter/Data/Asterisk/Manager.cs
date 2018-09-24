using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
        public string Deny { get; set; }
        public string Permit { get; set; }
        public string Read { get; set; }
        public string Write { get; set; }
        public int? Writetimeout { get; set; }
    }
}
