using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class BroadcastCampaigns
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmailSettings { get; set; }
        public sbyte Active { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeFinish { get; set; }
        public int WeekdayStart { get; set; }
        public int WeekdayFinish { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string DestinationPerson { get; set; }
        public string DestinationMachine { get; set; }
        public sbyte Completed { get; set; }
        public string Callerid { get; set; }
        public string Uniqueid { get; set; }
        public int? Concurrentcalls { get; set; }
        public int? Retries { get; set; }
        public string Prefix { get; set; }
        public int? Dupes { get; set; }
    }
}
