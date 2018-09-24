using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class SoundlangPackages
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Module { get; set; }
        public string Language { get; set; }
        public byte[] License { get; set; }
        public string Author { get; set; }
        public string Authorlink { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public string Installed { get; set; }
    }
}
