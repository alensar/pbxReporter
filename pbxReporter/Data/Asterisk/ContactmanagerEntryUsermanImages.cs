using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ContactmanagerEntryUsermanImages
    {
        public int Uid { get; set; }
        public byte[] Image { get; set; }
        public string Format { get; set; }
        public sbyte Gravatar { get; set; }
    }
}
