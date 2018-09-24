using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BroadcastLog
    {
        public int Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Callid { get; set; }
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string Callee { get; set; }
        public sbyte InitiatedDial { get; set; }
        public sbyte Answer { get; set; }
        public string DeliveredTo { get; set; }
        public string Uniqueid { get; set; }
        public sbyte? Attempt { get; set; }
        public string Dialednum { get; set; }
        public string Dialedname { get; set; }
    }
}
