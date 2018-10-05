using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Ptc.Demo.DataBase.UserAuthentication;
using Ptc.Demo.Web.Identity;
using Ptc.Demo.Web.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ptc.Demo.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public AccountController()
        {
         
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(AccountViewModel model, string returnUrl)
        {

            //轉成MD5
            //var md5Password = PasswordUtil.GetMd5Hash(model.Password).ToUpper();

            var user = await UserManager.FindAsync(model.UserName, model.Password);

            await SignInAsync(user, model.IsRemember);

            return RedirectToAction("Index", "Home");

        }

        public ActionResult LogOff()
        {
            MvcSiteMapProvider.SiteMaps.ReleaseSiteMap();
            AuthenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

        private async Task SignInAsync(IdentityUser user, bool isPersistent)
        {

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, await UserStore.GenerateUserIdentityAsync(user));

        }

       
    }
}