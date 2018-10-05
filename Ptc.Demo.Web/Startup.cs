using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Infrastructure;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.DataBase.UserAuthentication;
using Ptc.Demo.Web.Identity;

[assembly: OwinStartup(typeof(Ptc.Demo.Web.Startup))]

namespace Ptc.Demo.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }


        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(() => new SETOPEntities());
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            var cookieOptions = new CookieAuthenticationOptions
            {
                LogoutPath = new PathString("/Account/Login"),
                LoginPath = new PathString("/Account/Login"),
                ExpireTimeSpan = System.TimeSpan.FromMinutes(30),
                CookieManager = new CookieManager(),
                Provider = new CookieAuthenticationProvider()
                {
                    OnResponseSignIn = ctx =>
                    {
                        // This method was NOT being called
                    },


                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, IdentityUser>(
                       validateInterval: TimeSpan.FromMinutes(30),
                       regenerateIdentity: (manager, user) => {

                           return UserStore.GenerateUserIdentityAsync(user);
                       }),
                    OnApplyRedirect = ctx =>
                    {
                        if (!IsApiRequest(ctx.Request))
                        {
                            ctx.Response.Redirect(ctx.RedirectUri);
                        }
                    }

                },
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,

                // CookieSecure = CookieSecureOption.Always
            };

            app.UseCookieAuthentication(cookieOptions);
        }
        private static bool IsApiRequest(IOwinRequest request) => request.Path.ToString().Contains("/api/");
    }
}
