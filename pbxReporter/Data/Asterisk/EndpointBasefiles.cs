using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class EndpointBasefiles
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Template { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string File { get; set; }
        public string Define { get; set; }
        public string Param { get; set; }
        public string Attrib { get; set; }
        public string Value { get; set; }
        public string Edited { get; set; }
        public string Description { get; set; }
        public string Oid { get; set; }
    }
}
