using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Tts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Goto { get; set; }
        public string Engine { get; set; }
    }
}
