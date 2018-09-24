using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ContactmanagerGroupEntries
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int Groupid { get; set; }
        public int User { get; set; }
        public string Displayname { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
    }
}
