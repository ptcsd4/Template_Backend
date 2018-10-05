using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Ptc.Demo.DataBase.SETOP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.DataBase.UserAuthentication
{

    public class UserStore : UserStore<IdentityUser>
    {
        public UserStore(DbContext context) : base(context)
        {

        }

        public static async Task<ClaimsIdentity> GenerateUserIdentityAsync(IdentityUser user)
        {
            // 注意 authenticationType 必須符合 CookieAuthenticationOptions.AuthenticationType 中定義的項目

            var userIdentity = new ClaimsIdentity(new Identity()
            {
                IsAuthenticated = true,
                Name = user.UserName,
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            });

            // 在這裡新增自訂使用者宣告
            return userIdentity;
        }

    }

    public class UserStore<TUser> : UserStore<TUser, IdentityRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>,
                                    IUserStore<TUser>,
                                    IUserStore<TUser, string>,
                                    IDisposable where TUser : IdentityUser
    {


        private SETOPEntities _ctx;

        public UserStore(DbContext context) : base(context)
        {
            _ctx = (SETOPEntities)context;
        }

        public override Task<TUser> FindByIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentException("Null or empty argument: userId");
            }

            var user = _ctx.AspNetUsers.FirstOrDefault(con => con.Id == userId);

            if (user == null)
                throw new NullReferenceException($"找不到使用者{ userId}");

            TUser currentUser = (TUser)Activator.CreateInstance(typeof(TUser));
            currentUser.Id = user.Id;
            currentUser.UserName = user.UserName;
            currentUser.PasswordHash = user.PasswordHash;


            return Task.FromResult<TUser>(currentUser);
        }
        public override Task<TUser> FindByNameAsync(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentException("Null or empty argument: userName");

            var user = _ctx.AspNetUsers
                           .FirstOrDefault(x => x.UserName == userName);

            if (user == null)
                throw new NullReferenceException($"找不到使用者{ userName}");



            TUser currentUser = (TUser)Activator.CreateInstance(typeof(TUser));
            currentUser.Id = user.Id;
            currentUser.UserName = user.UserName;
            currentUser.PasswordHash = user.PasswordHash;


            return Task.FromResult<TUser>(currentUser);
        }
        public override Task<IList<Claim>> GetClaimsAsync(TUser user)
        {
            return Task.FromResult<IList<Claim>>(new List<Claim>() { });
        }
        public override Task<string> GetPasswordHashAsync(TUser user)
        {

            if (user == null)
                throw new ArgumentException("Null or empty argument: userName");

            var currentUser = _ctx.AspNetUsers.FirstOrDefault(con => con.Id == user.Id);
            if (currentUser == null)
                throw new NullReferenceException($"找不到使用者{ user.Id}");



            return Task.FromResult<string>(currentUser.PasswordHash);
        }

      

    }
}
