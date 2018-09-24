using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VqplusQueueConfig
    {
        public string QueueNum { get; set; }
        public int? MinPenalty { get; set; }
        public int? MaxPenalty { get; set; }
        public int? RuleId { get; set; }
        public string Cdest { get; set; }
        public string Adest { get; set; }
        public string FullDest { get; set; }
        public string JoinemptyDest { get; set; }
        public string LeaveemptyDest { get; set; }
        public string JoinunavailDest { get; set; }
        public string LeaveunavailDest { get; set; }
        public string Upil { get; set; }
        public string Lazymembers { get; set; }
    }
}
