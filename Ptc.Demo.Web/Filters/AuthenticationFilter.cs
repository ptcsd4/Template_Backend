using Ptc.Data.Condition2.Mssql.Repository;

using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.Domain;
using Ptc.Demo.Domain.Business.Class;
using Ptc.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc.Filters;

namespace Ptc.Demo.Web.Filters
{
    public class AuthenticationFilter : System.Web.Mvc.ActionFilterAttribute, IAuthenticationFilter
    {
        public ILogger _Logger { get; set; }

        public IMSSQLRepository<AspNetUsers, User> _UserRepo { get; set; }

   
        public void OnAuthentication(AuthenticationContext filterContext)
        {

            User user = _UserRepo.Get(x => x.UserName == filterContext.Principal.Identity.Name);

            if (user == null)
            {
                filterContext.Result = new System.Web.Mvc.HttpUnauthorizedResult();
                return;
            }

            if (IsValid(user) == false)
            {
                filterContext.Result = new System.Web.Mvc.HttpUnauthorizedResult();
                return;
            }

            DataBase.UserAuthentication.Identity identity = new DataBase.UserAuthentication.Identity(user, filterContext.Principal.Identity);

            IPrincipal principal = new GenericPrincipal(identity, null);

            filterContext.Principal = principal;
        }

        public virtual Boolean IsValid(User user)
        {
            return true;
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

        }
    }
}