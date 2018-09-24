using pbxReporter.Data.Asterisk;
using pbxReporter.Data.Asteriskcdrdb;
using pbxReporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pbxReporter.Engines
{
    public class Reports
    {
        private readonly asteriskContext asterisk;
        private readonly asteriskcdrdbContext cdr;

        public Reports(asteriskcdrdbContext asteriskcdrdbContext, asteriskContext asteriskContext)
        {
            asterisk = asteriskContext;
            cdr = asteriskcdrdbContext;
        }

        private DateTime datumIzFiltera(GridCdrFilter filter, string kolona, string opretert)
        {
            return  filter
                        .FilterGroups.Where(x => x.Field == kolona)
                        .Select(y =>
                                    y.Filters.Where(xy => xy.Condition == opretert).Select(fifi => DateTime.ParseExact(fifi.Value.Substring(0, 24),
                              "ddd MMM d yyyy HH:mm:ss",
                              System.Globalization.CultureInfo.InvariantCulture)
                              ).FirstOrDefault()
                               ).FirstOrDefault();
        }

        private List<string> filterEktenzija(GridCdrFilter filter, string kolona)
        {
           return filter.FilterGroups.Where(grupa => grupa.Field == kolona)
                .SelectMany(xy => xy.Filters
                .Select(yy => yy.Value.Substring(0,yy.Value.IndexOf('~')) 
                )).ToList();
        }
        private List<string> filterMultipleString(GridCdrFilter filter, string kolona)
        {
            return filter.FilterGroups.Where(grupa => grupa.Field == kolona)
                 .SelectMany(xy => xy.Filters
                 .Select(yy => yy.Value
                 )).ToList();
        }

        private string stringFilter (GridCdrFilter filter, string kolona)
        {
            return  filter.FilterGroups.Where(x => x.Field == kolona).SelectMany(xy => xy.Filters.Select(yyy => yyy.Value)).FirstOrDefault();
        }

        public List<Models.GridCdr> gridCdrs(string jsonData, List<Data.Asterisk.Users> dostupneExtenzije)
        {
            var users = asterisk.Users.ToList();
            var exts = dostupneExtenzije.Select(x => x.Extension).ToList();
            var ekstnezije = users.Select(x => x.Extension).ToList();

            var filter = Models.GridCdrFilter.FromJson(jsonData);

            var odDatuma = datumIzFiltera(filter, "datum", "GREATER_THAN_OR_EQUAL");
            var doDatuma = datumIzFiltera(filter, "datum", "LESS_THAN_OR_EQUAL");

            var filterExts = filterEktenzija(filter, "extNumber");

            var filterExtName = stringFilter(filter, "extName");
            var srcFilter = stringFilter(filter, "pozivaoc");
            var dstFilter = stringFilter(filter, "pozivani");

            var filterDurtanionSec = filter.FilterGroups.Where(x => x.Field == "durationSec").SelectMany(x => x.Filters).FirstOrDefault();
            int filterDurtanionSecSec = 0;
            if (filterDurtanionSec != null)
            {
                int.TryParse(filterDurtanionSec.Value, out filterDurtanionSecSec);
            }

            var filterBilSecSec = filter.FilterGroups.Where(x => x.Field == "bilSecSec").SelectMany(x => x.Filters).FirstOrDefault();
            int filterBilSecSecSec = 0;
            if (filterBilSecSec != null)
            {
                int.TryParse(filterBilSecSec.Value, out filterBilSecSecSec);
            }

            var filterPozivStatus = filterMultipleString(filter, "pozivStatus");
            var filterPozivTip = filterMultipleString(filter, "pozivTip");

            List<Models.GridCdr> data =
                    cdr.Cdr.OrderByDescending(y => y.Id)
                    .Where(x => dostupneExtenzije.Count == users.Count || exts.Contains(x.Src) || exts.Contains(x.Dst))
                    .Where ( x=> odDatuma ==  DateTime.MinValue || x.Calldate.Date >= odDatuma.Date )
                    .Where ( x=> doDatuma ==  DateTime.MinValue || x.Calldate.Date <= doDatuma.Date )
                    .Where( x=> filterExts.Count == 0 || filterExts.Contains(x.Src) || filterExts.Contains(x.Dst))
                    .Where( x=> string.IsNullOrEmpty(filterExtName) 
                            || users.Where(usr=> usr.Name.ToUpper().Contains(filterExtName.ToUpper())).Select(xxxx=> xxxx.Extension).Contains(x.Src)
                            || users.Where(usr=> usr.Name.ToUpper().Contains(filterExtName.ToUpper())).Select(xxxx=> xxxx.Extension).Contains(x.Dst)
                            )
                    .Where( x=> string.IsNullOrEmpty(srcFilter) || x.Src.Contains(srcFilter))
                    .Where( x=> string.IsNullOrEmpty(dstFilter) || x.Dst.Contains(dstFilter))
                    .Where( x=> filterPozivStatus.Count == 0  || filterPozivStatus.Contains(x.Disposition) )
                    .Where( x=> filterDurtanionSec == null
                               || (filterDurtanionSec.Condition == "EQUAL" && x.Duration == filterDurtanionSecSec)
                               || (filterDurtanionSec.Condition == "NOT_EQUAL" && x.Duration != filterDurtanionSecSec)

                               || (filterDurtanionSec.Condition == "LESS_THAN" && x.Duration < filterDurtanionSecSec)
                               || (filterDurtanionSec.Condition == "LESS_THAN_OR_EQUAL" && x.Duration <= filterDurtanionSecSec)

                               || (filterDurtanionSec.Condition == "GREATER_THAN" && x.Duration > filterDurtanionSecSec)
                               || (filterDurtanionSec.Condition == "GREATER_THAN_OR_EQUAL" && x.Duration >= filterDurtanionSecSec)
                               
                               || (filterDurtanionSec.Condition == "NULL" && x.Duration == 0)
                               || (filterDurtanionSec.Condition == "NOT_NULL" && x.Duration != 0)
                            )
                    .Where(x => filterBilSecSec == null
                              || (filterBilSecSec.Condition == "EQUAL" && x.Billsec == filterBilSecSecSec)
                              || (filterBilSecSec.Condition == "NOT_EQUAL" && x.Billsec != filterBilSecSecSec)

                              || (filterBilSecSec.Condition == "LESS_THAN" && x.Billsec < filterBilSecSecSec)
                              || (filterBilSecSec.Condition == "LESS_THAN_OR_EQUAL" && x.Billsec <= filterBilSecSecSec)

                              || (filterBilSecSec.Condition == "GREATER_THAN" && x.Billsec > filterBilSecSecSec)
                              || (filterBilSecSec.Condition == "GREATER_THAN_OR_EQUAL" && x.Billsec >= filterBilSecSecSec)

                              || (filterBilSecSec.Condition == "NULL" && x.Billsec == 0)
                              || (filterBilSecSec.Condition == "NOT_NULL" && x.Billsec != 0)
                            )
                     .Where(x=>
                            filterPozivTip.Count == 0
                            || (filterPozivTip.Contains("Interni") && ekstnezije.Contains(x.Src) && ekstnezije.Contains(x.Dst) )
                            || (filterPozivTip.Contains("Odlazni") && ekstnezije.Contains(x.Src) && !ekstnezije.Contains(x.Dst))
                            || (filterPozivTip.Contains("Dolazni") && !ekstnezije.Contains(x.Src) && ekstnezije.Contains(x.Dst))
                            || (filterPozivTip.Contains("Ostali") && !ekstnezije.Contains(x.Src) && !ekstnezije.Contains(x.Dst) )


                     )
                    //.Take(1099)
                    .Select(x => new Models.GridCdr()
                    {
                        id = x.Id,
                        datum = x.Calldate.Date,
                        vrijeme = x.Calldate,
                        durationSec = x.Duration ,
                        bilSecSec = x.Billsec ,
                        duration = TimeSpan.FromSeconds(double.Parse(x.Duration.ToString())).ToString("hh':'mm':'ss"),
                        bilSec = TimeSpan.FromSeconds(double.Parse(x.Billsec.ToString())).ToString("hh':'mm':'ss"),
                        pozivani = x.Dst,
                        pozivaoc = x.Src,
                        pozivStatus = x.Disposition,
                        pozivTip = ekstnezije.Contains(x.Src) && ekstnezije.Contains(x.Dst) ? "Interni"
                                    : ekstnezije.Contains(x.Src) ? "Odlazni"
                                    : ekstnezije.Contains(x.Dst) ? "Dolazni"
                                    : "Ostali"

                        ,
                        extName = users.Where(y => y.Extension == x.Src || y.Extension == x.Dst).Select(y => y.Name).FirstOrDefault(),
                        extNumber = users.Where(y => y.Extension == x.Src || y.Extension == x.Dst).Select(y => y.Extension).FirstOrDefault()
                    }).ToList();

            return data;
        }
    }
}
