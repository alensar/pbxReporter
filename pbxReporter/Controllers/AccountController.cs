using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using pbxReporter.Models;

namespace pbxReporter.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly Data.Asterisk.asteriskContext asterisk;
        public AccountController(Data.Asterisk.asteriskContext asteriskContext)
        {
            asterisk = asteriskContext;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Models.LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = isUserValid(model);
                if (user.prosao)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.userName.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.userName));
                    claims.Add(new Claim("extensionHigh", user.extensionHigh));
                    claims.Add(new Claim("extensionLow", user.extensionLow));

                    var roles = user.roles.Split(';').ToList();

                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var id = new ClaimsIdentity(claims, "local");
                    var p = new ClaimsPrincipal(id);
                    await HttpContext.SignInAsync(p);
                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, user.poruka);
                    return View(model);
                }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        private Models.UserViewModel isUserValid(Models.LoginViewModel loginViewModel)
        {

            UserViewModel uvm = new UserViewModel();
            try
            {
                uvm.poruka = "Nisam se još implemantirao";
                var user = asterisk.Ampusers.Where(x => x.Username == loginViewModel.userName).FirstOrDefault();
                if (user == null)
                {
                    uvm.poruka = "U bazi ne postoji korisnik pod korisničkim imenom: " + loginViewModel.userName;
                    return uvm;
                }
                var pass = shaPassword(loginViewModel.Password);
                if (user.PasswordSha1 != pass)
                {
                    uvm.poruka = "Neispravan password";
                    return uvm;
                }

                var selction = System.Text.Encoding.Default.GetString(user.Sections);

                if (string.IsNullOrEmpty(selction) || (!selction.Contains("CDR") && !selction.Contains("cdr") && !selction.Contains("*")))
                {
                    uvm.poruka = "Vašem korsiniku nisu dodjeljnja prava pristupa CDR reportima";
                    return uvm;
                }
                uvm.roles = selction;
                uvm.extensionHigh = user.ExtensionHigh;
                uvm.extensionLow = user.ExtensionLow;
                uvm.userName = user.Username;
                uvm.poruka = "Uspijšena prijava u sistem prijava na sistem";
                uvm.prosao = true;
                return uvm;
            }
            catch (Exception ex)
            {
                uvm.poruka = "Sistemska greška (molimo vas kontaktirajte administratora ! \n EX: " + ex.Message;
            }
            return uvm;

        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return Redirect("/");
            }
        }

        private string shaPassword(string pass)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pass));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();

            }
        }

        [Authorize]
        public IActionResult AccessDenied(string ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View("Odbijen");
        }
    }
}