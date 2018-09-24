using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DigiumaddoninstallerAddons
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Documentation { get; set; }
        public uint ProductIndex { get; set; }
        public uint CategoryIndex { get; set; }
        public uint RegisterLimit { get; set; }
        public string Status { get; set; }
        public string SupportedVersion { get; set; }
        public sbyte IsInstalled { get; set; }
        public sbyte IsUptodate { get; set; }
        public sbyte IsRegistered { get; set; }
    }
}
