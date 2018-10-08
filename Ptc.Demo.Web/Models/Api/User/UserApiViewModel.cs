using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.Models.Api.User
{
    public class UserApiViewModel
    {
        public UserApiViewModel(Domain.Business.Class.User User)
        {
            this.UserID = User.UserID;
            this.Password = User.PasswordHash;
     
        }
        public string UserID { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}