using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class OutboundRoutePatterns
    {
        public int RouteId { get; set; }
        public string MatchPatternPrefix { get; set; }
        public string MatchPatternPass { get; set; }
        public string MatchCid { get; set; }
        public string PrependDigits { get; set; }
    }
}
