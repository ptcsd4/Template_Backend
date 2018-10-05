using Ptc.Data.Condition2.Mssql.Repository;
using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.Domain.Business.Class;
using Ptc.Demo.Domain.Common;
using Ptc.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Ptc.Demo.Web.Api_Controllers
{
    public class UserApiController : ApiController
    {
        private readonly ILogger _Logger;
        private readonly IMSSQLRepository<AspNetUsers, User> _UserRepo;


        public UserApiController(ILogger Logger,
                                 IMSSQLRepository<AspNetUsers, User> UserRepo)
        {
            _Logger = Logger;
            _UserRepo = UserRepo;
        }

        [HttpPost]
        public HttpResponseMessage GetList()
        {
            try
            {
                var users = _UserRepo.GetList();

                return Request.CreateResponse(
                       HttpStatusCode.OK,
                       new JsonResult<IEnumerable<User>>(users, true));

            }
            catch (Exception ex)
            {
                _Logger.Error(ex.Message);

                return Request.CreateResponse(
                        HttpStatusCode.OK,
                        new JsonResult<Boolean>(false, $"{ex.Message}"));
            }
        }



    }
}
