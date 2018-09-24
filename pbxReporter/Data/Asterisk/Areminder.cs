using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Areminder
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte Enabled { get; set; }
        public int Start1 { get; set; }
        public int Start2 { get; set; }
        public int Start3 { get; set; }
        public int Start4 { get; set; }
        public int Start5 { get; set; }
        public int Start6 { get; set; }
        public int Start7 { get; set; }
        public int Stop1 { get; set; }
        public int Stop2 { get; set; }
        public int Stop3 { get; set; }
        public int Stop4 { get; set; }
        public int Stop5 { get; set; }
        public int Stop6 { get; set; }
        public int Stop7 { get; set; }
        public string Outcid { get; set; }
        public string Outcidname { get; set; }
        public string Cidtype { get; set; }
        public uint Maxnotice { get; set; }
        public ushort Retrycount { get; set; }
        public ushort Retrydelay { get; set; }
        public ushort Greetingid { get; set; }
        public ushort Greeting2id { get; set; }
        public byte Sayname { get; set; }
        public byte Saydate { get; set; }
        public ushort Instructionsid { get; set; }
        public string Csext { get; set; }
        public string Resched { get; set; }
        public string Schedext { get; set; }
        public int Ttsengine { get; set; }
        public string Emailcomplete { get; set; }
        public string Emailfrom { get; set; }
        public string Attachas { get; set; }
        public uint Lastemail { get; set; }
    }
}
