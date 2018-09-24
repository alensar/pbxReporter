using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ContactmanagerGroups
    {
        public int Id { get; set; }
        public int Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
