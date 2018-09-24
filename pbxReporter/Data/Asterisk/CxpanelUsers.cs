using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CxpanelUsers
    {
        public int CxpanelUserId { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Peer { get; set; }
        public int AddExtension { get; set; }
        public int Full { get; set; }
        public int AddUser { get; set; }
        public string HashedPassword { get; set; }
        public string InitialPassword { get; set; }
        public int AutoAnswer { get; set; }
        public string ParentUserId { get; set; }
        public int PasswordDirty { get; set; }
    }
}
