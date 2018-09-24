using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Motif
    {
        public int Id { get; set; }
        public string Phonenum { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public string OauthSecret { get; set; }
        public string OauthClientid { get; set; }
        public string Type { get; set; }
        public byte[] Settings { get; set; }
        public string Statusmessage { get; set; }
        public int Priority { get; set; }
        public string Authmode { get; set; }
    }
}
