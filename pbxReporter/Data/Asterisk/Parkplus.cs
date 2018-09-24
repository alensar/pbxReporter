using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Parkplus
    {
        public long Id { get; set; }
        public string Defaultlot { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Parkext { get; set; }
        public string Parkpos { get; set; }
        public int Numslots { get; set; }
        public int Parkingtime { get; set; }
        public string Parkedmusicclass { get; set; }
        public string Generatefc { get; set; }
        public string Findslot { get; set; }
        public string Parkedplay { get; set; }
        public string Parkedcalltransfers { get; set; }
        public string Parkedcallreparking { get; set; }
        public string Alertinfo { get; set; }
        public string Rvolume { get; set; }
        public string Cidpp { get; set; }
        public string Autocidpp { get; set; }
        public int? AnnouncementId { get; set; }
        public string Comebacktoorigin { get; set; }
        public string Dest { get; set; }
    }
}
