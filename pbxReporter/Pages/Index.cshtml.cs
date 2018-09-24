using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pbxReporter.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {

        public ActionResult OnGet()
        {
          return  RedirectToAction("Index", "Reports");
        }
    }
}
