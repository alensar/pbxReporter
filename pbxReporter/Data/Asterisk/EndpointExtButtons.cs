using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class EndpointExtButtons
    {
        public long Id { get; set; }
        public string Ext { get; set; }
        public string Brand { get; set; }
        public string TemplateName { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
