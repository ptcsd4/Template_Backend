
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

using Trade = Ptc.Demo.Domain.Business.Class.Trade;

namespace Ptc.Demo.Web.Api_Controllers
{
    public class TradeApiController : ApiController
    {
        private readonly ILogger _Logger;
        private readonly IMSSQLRepository<DataBase.SETOP.Trade, Trade> _TradeRepo;

        public TradeApiController(ILogger Logger,
                                  IMSSQLRepository<DataBase.SETOP.Trade, Trade> TradeRepo)
        {
            _Logger = Logger;
            _TradeRepo = TradeRepo;
        }

        [HttpPost]
        public HttpResponseMessage GetList()
        {
            try
            {
                _TradeRepo.OverrideDBContext(() => new OPTradeEntities());

                var trades = _TradeRepo.GetList();

                return Request.CreateResponse(
                       HttpStatusCode.OK,
                       new JsonResult<IEnumerable<Trade>>(trades, true));

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
