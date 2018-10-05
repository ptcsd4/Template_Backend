using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.DataBase.UserAuthentication
{
    public class IdentityUser : Microsoft.AspNet.Identity.EntityFramework.IdentityUser
    {
        public IdentityUser() : base()
        {
            Id = Guid.NewGuid().ToString();
            SecurityStamp = Guid.NewGuid().ToString();
        }

        public override string UserName { get; set; }
    }
}
