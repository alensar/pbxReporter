using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using pbxReporter.Data.Asterisk;
using pbxReporter.Data.Asteriskcdrdb;

namespace pbxReporter.Controllers
{
    [Authorize(Roles = "*,cdr")]
    [Route("[controller]/[action]")]
    public class ReportsController : Controller
    {
        private readonly asteriskContext asterisk;
        private readonly asteriskcdrdbContext cdr;
        private pbxReporter.Engines.Reports engin;

        public ReportsController(asteriskContext asteriskContext, asteriskcdrdbContext asteriskcdrdbContext)
        {
            asterisk = asteriskContext;
            cdr = asteriskcdrdbContext;
            engin = new Engines.Reports(asteriskcdrdbContext, asteriskContext);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public JsonResult gridCdr(string jsonData,bool init)
        {
            if (init)
                return Json(null);
            var extens = dostupneEkstenzijeList();
            var data = engin.gridCdrs(jsonData, extens);
            return Json(data);

        }

        public JsonResult dostupneEksteznije()
        {
            var data = dostupneEkstenzijeList().Select(x => x.Extension + "~" + x.Name);
            return Json(data);

        }
        public JsonResult statusiPoziva()
        {

          
            return Json(null);
        }
        private List<Data.Asterisk.Users> dostupneEkstenzijeList()
        {

            var identity = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identity.Claims;


            int fromExt = 0;
            int toExt = 0;

            int.TryParse(claims.Where(x => x.Type == "extensionLow").Select(x => x.Value).FirstOrDefault(), out fromExt);
            int.TryParse(claims.Where(x => x.Type == "extensionHigh").Select(x => x.Value).FirstOrDefault(), out toExt);

            var data = asterisk.Users
                .Where(x => fromExt == 0 || int.Parse(x.Extension) >= fromExt)
                .Where(x => toExt == 0 || int.Parse(x.Extension) <= toExt)
                .OrderBy(x => x.Extension)
                .ToList();

            return data;

        }
        [HttpPost]
        [DisableRequestSizeLimit]
        public FileContentResult GridExport(string filename, string format, string content)
        {
            var contentType = "text/xml";
            var bytes = Encoding.UTF8.GetBytes(content);
            var result = new FileContentResult(bytes, contentType);
            result.FileDownloadName = filename + "." + format;

            return result;

        }
    }
}