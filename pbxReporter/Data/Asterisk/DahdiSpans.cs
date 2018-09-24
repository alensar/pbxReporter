using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class DahdiSpans
    {
        public int Id { get; set; }
        public int Span { get; set; }
        public sbyte? Active { get; set; }
        public string Alarms { get; set; }
        public int? Basechan { get; set; }
        public string Coding { get; set; }
        public string CodingOpts { get; set; }
        public string Context { get; set; }
        public int? Definedchans { get; set; }
        public string Description { get; set; }
        public string Devicetype { get; set; }
        public string Framing { get; set; }
        public string FramingOpts { get; set; }
        public int? Group { get; set; }
        public string Irq { get; set; }
        public int? Lbo { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int? MaxCh { get; set; }
        public int? MinCh { get; set; }
        public string Pridialplan { get; set; }
        public string Prilocaldialplan { get; set; }
        public int? ReservedCh { get; set; }
        public string Signalling { get; set; }
        public string Spantype { get; set; }
        public string Switchtype { get; set; }
        public int? Syncsrc { get; set; }
        public int? Timing { get; set; }
        public int? Totchans { get; set; }
        public string Type { get; set; }
        public string Priexclusive { get; set; }
        public byte[] AdditionalGroups { get; set; }
        public string Txgain { get; set; }
        public string Rxgain { get; set; }
        public string Mfcr2Variant { get; set; }
        public string Mfcr2GetAniFirst { get; set; }
        public short Mfcr2MaxAni { get; set; }
        public short Mfcr2MaxDnis { get; set; }
        public string Mfcr2Category { get; set; }
        public string Mfcr2CallFiles { get; set; }
        public string Mfcr2SkipCategory { get; set; }
        public string Mfcr2Logdir { get; set; }
        public string Mfcr2Logging { get; set; }
        public decimal Mfcr2MfbackTimeout { get; set; }
        public decimal Mfcr2MfbackPulseTimeout { get; set; }
        public decimal Mfcr2MeteringPulseTimeout { get; set; }
        public string Mfcr2AllowCollectCalls { get; set; }
        public string Mfcr2DoubleAnswer { get; set; }
        public string Mfcr2ImmediateAccept { get; set; }
        public string Mfcr2ForcedRelease { get; set; }
        public string Mfcr2ChargeCalls { get; set; }
        public string Mfcr2AcceptOnOffer { get; set; }
        public string Mfcr2SkipCatefory { get; set; }
        public string Mfcr2AdvancedProtocolFile { get; set; }
    }
}
