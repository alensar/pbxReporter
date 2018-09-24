using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class OutboundRoutes
    {
        public int RouteId { get; set; }
        public string Name { get; set; }
        public string Outcid { get; set; }
        public string OutcidMode { get; set; }
        public string Password { get; set; }
        public string EmergencyRoute { get; set; }
        public string IntracompanyRoute { get; set; }
        public string Mohclass { get; set; }
        public int? TimeGroupId { get; set; }
        public string Dest { get; set; }
        public string TimeMode { get; set; }
        public string CalendarId { get; set; }
        public string CalendarGroupId { get; set; }
        public string Timezone { get; set; }
    }
}
