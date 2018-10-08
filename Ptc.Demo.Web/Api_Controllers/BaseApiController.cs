using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ptc.Demo.Web.Api_Controllers
{
    public class BaseApiController : ApiController
    {
        public DataBase.UserAuthentication.Identity CurrentUser
        {
            get
            {
                
                return (DataBase.UserAuthentication.Identity)this.User.Identity;
            }
        }
    }
}
