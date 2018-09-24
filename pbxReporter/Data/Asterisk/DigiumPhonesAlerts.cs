using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DigiumPhonesAlerts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alertinfo { get; set; }
        public string Type { get; set; }
        public int? Ringtone { get; set; }
    }
}
