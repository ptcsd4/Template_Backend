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
    public class BaseController : Controller
    {
        public DataBase.UserAuthentication.Identity UserInfo
        {
            get
            {
                return ((DataBase.UserAuthentication.Identity)this.User.Identity);
            }
        }
    }
}
