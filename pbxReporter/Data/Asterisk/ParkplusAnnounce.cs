using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class ParkplusAnnounce
    {
        public int Id { get; set; }
        public string Announceext { get; set; }
        public string Name { get; set; }
        public string RecordMessage { get; set; }
        public string RecordAnnouncementId { get; set; }
        public int? RecordMessageLength { get; set; }
        public int? RecordMessageSilence { get; set; }
        public string SuccessfulRecordingId { get; set; }
        public string FailureRecordingId { get; set; }
        public int ParkId { get; set; }
        public string PrimaryAnnouncementId { get; set; }
        public string ReplaceAnnouncementId { get; set; }
        public int Parkingtime { get; set; }
        public sbyte? ParkingtimeEnable { get; set; }
        public int Parkingretry { get; set; }
        public string Comebacktoorigin { get; set; }
        public string Dest { get; set; }
        public string PageId { get; set; }
        public string SlotAnnounceEnable { get; set; }
        public string PageAnnouncementId1 { get; set; }
        public string PageAnnouncementId2 { get; set; }
        public string PageAnnouncementId3 { get; set; }
        public string Cidpp { get; set; }
        public string Autocidpp { get; set; }
        public int PageTimerExtend { get; set; }
        public byte[] AnnounceOrder { get; set; }
        public string PageAnnouncementId { get; set; }
        public int? AnnounceRepeat { get; set; }
    }
}
