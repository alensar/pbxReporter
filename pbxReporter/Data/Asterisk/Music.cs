using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Music
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public sbyte? Random { get; set; }
        public string Application { get; set; }
        public string Format { get; set; }
    }
}
