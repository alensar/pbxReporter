using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class VirtualQueueConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public int? Position { get; set; }
        public int? MinPenalty { get; set; }
        public int? MaxPenalty { get; set; }
        public int? RuleId { get; set; }
        public int? JoinannounceId { get; set; }
        public int? AgentannounceId { get; set; }
        public string Music { get; set; }
        public string Maxwait { get; set; }
        public string Cidpp { get; set; }
        public string Alertinfo { get; set; }
        public string Language { get; set; }
        public int? CallconfirmId { get; set; }
        public string Dest { get; set; }
        public string Cdest { get; set; }
        public string Adest { get; set; }
        public string Gotodest { get; set; }
        public string FullDest { get; set; }
        public string JoinemptyDest { get; set; }
        public string LeaveemptyDest { get; set; }
        public string JoinunavailDest { get; set; }
        public string LeaveunavailDest { get; set; }
    }
}
