using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class CxpanelPhoneNumber
    {
        public int CxpanelPhoneNumberId { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
    }
}
