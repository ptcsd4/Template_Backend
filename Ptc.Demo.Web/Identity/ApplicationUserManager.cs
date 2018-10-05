using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Ptc.Demo.DataBase.UserAuthentication;
using Ptc.Demo.DataBase.SETOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.Identity
{

    public class ApplicationUserManager : UserManager<IdentityUser>
    {

        private const string Purpose = "ASP.NET Identity";

        public ApplicationUserManager(IUserStore<IdentityUser> store) : base(store)
        {

        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
       
            var ctx = context.Get<SETOPEntities>();


            var manager = new ApplicationUserManager(new UserStore<IdentityUser>(ctx));

            manager.UserValidator = new UserValidator<IdentityUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            manager.PasswordHasher = new PasswordManager();

            var dataProtectionProvider = options.DataProtectionProvider;

            if (dataProtectionProvider != null)
                manager.UserTokenProvider = new DataProtectorTokenProvider<IdentityUser>(dataProtectionProvider.Create(Purpose));
            
            return manager;
        }
    }
}