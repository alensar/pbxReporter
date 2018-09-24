using System;
using System.Collections.Generic;

namespace pbxReporter.Data.Asterisk
{
    public partial class Cidlookup
    {
        public int CidlookupId { get; set; }
        public string Description { get; set; }
        public string Sourcetype { get; set; }
        public short Cache { get; set; }
        public string Deptname { get; set; }
        public string HttpHost { get; set; }
        public string HttpPort { get; set; }
        public string HttpUsername { get; set; }
        public string HttpPassword { get; set; }
        public string HttpPath { get; set; }
        public string HttpQuery { get; set; }
        public string MysqlHost { get; set; }
        public string MysqlDbname { get; set; }
        public string MysqlQuery { get; set; }
        public string MysqlUsername { get; set; }
        public string MysqlPassword { get; set; }
        public string MysqlCharset { get; set; }
        public string OpencnamAccountSid { get; set; }
        public string OpencnamAuthToken { get; set; }
        public string CmGroup { get; set; }
        public string CmFormat { get; set; }
    }
}
