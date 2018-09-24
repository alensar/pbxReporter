using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DigiumPhonesRingtones
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public sbyte? Builtin { get; set; }
        public string Filename { get; set; }
    }
}
