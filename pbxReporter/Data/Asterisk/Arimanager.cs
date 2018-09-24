using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Arimanager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordFormat { get; set; }
        public int? ReadOnly { get; set; }
    }
}
