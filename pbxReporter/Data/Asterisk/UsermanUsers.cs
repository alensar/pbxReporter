using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class UsermanUsers
    {
        public int Id { get; set; }
        public string Auth { get; set; }
        public string Authid { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string DefaultExtension { get; set; }
        public int? PrimaryGroup { get; set; }
        public byte[] Permissions { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Displayname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Language { get; set; }
        public string Timezone { get; set; }
        public string Dateformat { get; set; }
        public string Timeformat { get; set; }
        public string Datetimeformat { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Work { get; set; }
        public string Home { get; set; }
        public string Fax { get; set; }
    }
}
