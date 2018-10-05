using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Business.Class
{
    public class User
    {
        public User()
        {

        }

        public string UserID { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }
    }
}
