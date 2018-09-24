using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ContactmanagerEntryNumbers
    {
        public int Id { get; set; }
        public int Entryid { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public string Type { get; set; }
        public string Flags { get; set; }
    }
}
