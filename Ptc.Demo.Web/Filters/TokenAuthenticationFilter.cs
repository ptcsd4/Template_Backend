using Microsoft.Owin.Logging;
using Ptc.Data.Condition2.Mssql.Repository;
using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.Domain;
using Ptc.Demo.Domain.Business.Class;
using Ptc.Demo.Shared.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http.Controllers;

namespace Ptc.Demo.Web.Filters
{
    public class TokenAuthenticationFilter : System.Web.Http.AuthorizeAttribute
    {

        public ILogger _Logger { get; set; }

        public IMSSQLRepository<AspNetUsers, User> _UserRepo { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query).Get("token");

            if (string.IsNullOrEmpty(token))
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                return;
            }

            var user = TokenUtility<User>.Parse(token);

            if (IsValid(user) == false)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                return;
            }

            DataBase.UserAuthentication.Identity identity = new DataBase.UserAuthentication.Identity(user, System.Threading.Thread.CurrentPrincipal.Identity);

            IPrincipal principal = new GenericPrincipal(identity, null);

            SetPrincipal(principal);

        }
        public virtual Boolean IsValid(User user)
        {
            return true;
        }


        private void SetPrincipal(IPrincipal principal)
        {
            System.Threading.Thread.CurrentPrincipal = principal;

            if (HttpContext.Current != null)
            {
                HttpContext.Current.User = principal;
            }
        }



    }
}