using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Webcallback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dest { get; set; }
        public string Cidprepend { get; set; }
        public string Numprepend { get; set; }
        public int? Accountcode { get; set; }
        public string ButtonAttr { get; set; }
        public string DialpadAttr { get; set; }
        public string Patterns { get; set; }
        public string ErrorMsg { get; set; }
        public string ValidMsg { get; set; }
        public string InvalidMsg { get; set; }
        public string Icon { get; set; }
    }
}
