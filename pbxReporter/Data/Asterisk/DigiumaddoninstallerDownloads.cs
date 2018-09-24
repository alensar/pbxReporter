using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DigiumaddoninstallerDownloads
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Package { get; set; }
        public string Tarball { get; set; }
        public string Path { get; set; }
        public string InstalledVersion { get; set; }
        public string AvailableVersion { get; set; }
    }
}
