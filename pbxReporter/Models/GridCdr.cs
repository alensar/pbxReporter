using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pbxReporter.Models
{
    public class GridCdr
    {
                public string extNumber { get;set;}
                public string extName { get;set;}
                public DateTime datum { get;set;}
                public DateTime vrijeme { get;set;}
                public string pozivaoc { get;set;}
                public string pozivani { get;set;}
                public string pozivTip { get;set;}
                public string pozivStatus { get;set;}
                public string duration { get;set;}
                public string bilSec  { get;set; }
                public int durationSec { get;set;}
                public int bilSecSec { get;set;}
                public int id { get; set; }
    }
}
