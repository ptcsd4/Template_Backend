using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.Models.Account
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {

        }
        public string UserName { get; set; }

        public string Password { get; set; }

        public Boolean IsRemember { get; set; }
    }
}