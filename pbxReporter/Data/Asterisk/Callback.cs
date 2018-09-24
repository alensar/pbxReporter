using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Callback
    {
        public int CallbackId { get; set; }
        public string Description { get; set; }
        public string Callbacknum { get; set; }
        public string Destination { get; set; }
        public int? Sleep { get; set; }
        public string Deptname { get; set; }
    }
}
