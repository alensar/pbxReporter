using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BroadcastCampaignGroups
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int GroupId { get; set; }
    }
}
