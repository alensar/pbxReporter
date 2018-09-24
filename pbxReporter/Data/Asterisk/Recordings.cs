using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Recordings
    {
        public int Id { get; set; }
        public string Displayname { get; set; }
        public byte[] Filename { get; set; }
        public string Description { get; set; }
        public sbyte? Fcode { get; set; }
        public string FcodePass { get; set; }
    }
}
