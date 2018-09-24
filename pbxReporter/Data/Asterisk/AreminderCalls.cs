using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class AreminderCalls
    {
        public uint Id { get; set; }
        public uint Arid { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public sbyte Status { get; set; }
        public int Retry { get; set; }
        public uint? Appointment { get; set; }
        public uint? Calltime { get; set; }
        public uint Length { get; set; }
        public string Notes { get; set; }
    }
}
