using Ptc.Data.Condition2.Mssql.Repository;
using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.Domain.Business.Class;
using Ptc.Demo.Domain.Common;
using Ptc.Demo.Shared.Utility;
using Ptc.Demo.Web.Models.Api.User;
using Ptc.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Ptc.Demo.Web.Api_Controllers
{
    [AllowAnonymous]
    public class UserApiController : BaseApiController
    {
        private readonly ILogger _Logger;
        private readonly IMSSQLRepository<AspNetUsers, User> _UserRepo;


        public UserApiController(ILogger Logger,
                                 IMSSQLRepository<AspNetUsers, User> UserRepo)
        {
            _Logger = Logger;
            _UserRepo = UserRepo;
        }

        [HttpGet]
        public HttpResponseMessage Login(string AccountID, string Password)
        {
            try
            {

                var currentUser = _UserRepo.Get(x => x.UserName == AccountID &&
                                                     x.PasswordHash == Password);

                if (currentUser == null) throw new NullReferenceException("帳號或密碼輸入錯誤");

                string token = TokenUtility<User>.Create(new User()
                {
                    UserID = currentUser.UserID,
                    UserName = currentUser.UserName
                });

                return Request.CreateResponse(
                HttpStatusCode.OK,
                new JsonResult<UserApiViewModel>(new UserApiViewModel(currentUser)
                {
                    Token = token
                },
                true, 
                "登入成功"));


            }
            catch (Exception ex)
            {

                _Logger.Error(ex.Message);

                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new JsonResult<Boolean>(false));
            }
        }

   



    }
}
