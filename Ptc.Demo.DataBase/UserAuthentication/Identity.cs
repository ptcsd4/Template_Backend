using Ptc.Demo.Domain;
using Ptc.Demo.Domain.Business.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.DataBase.UserAuthentication
{
    public class Identity : IIdentity
    {
    
        public Identity()
        {
        }
        
        public Identity(User user, IIdentity identity)
        {
            this.Name = identity.Name;
            this.UserName = user.UserName;
            this.AuthenticationType = identity.AuthenticationType;
            this.IsAuthenticated = identity.IsAuthenticated;
            this.User = user;
            
        }

  
        public string Name { get; set; }

        public string UserName { get; set; }

        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public User User { get; set; }

     
    }
}
