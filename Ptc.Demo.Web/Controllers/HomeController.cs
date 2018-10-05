using Ptc.Data.Condition2.Mssql.Class;
using Ptc.Data.Condition2.Mssql.Repository;
using Ptc.Demo.Domain.Business.Class;
using Ptc.Demo.Domain.Common;
using Ptc.Demo.Domain.Menu;
using Ptc.Demo.Web.Filters;
using Ptc.Demo.Web.Models;
using Ptc.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ptc.Demo.Web.Controllers
{
    [AuthenticationFilter]
    public class HomeController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IMSSQLRepository<DataBase.SETOP.Brand, Brand> _repo;

        public HomeController(ILogger Logger,
                              IMSSQLRepository<DataBase.SETOP.Brand, Brand> Repo)
        {
            _repo = Repo;
            _logger = Logger;
        }

        [MenuNode(
         Title = "我的首頁",
         Description = "我的首頁",
         PrefixedNodeID = "home",
         IsEntry = true)]
        public ActionResult Index()
        {
            return View(new BrandViewModel());
        }

        [HttpPost]
        public ActionResult GetList(DataTableReqModel<List<BrandViewModel>> DtWrapper)
        {
            DataTableRespModel<BrandListViewModel> result = null;

            try
            {
                List<BrandViewModel> models = DtWrapper.criteria;

                MSSQLCondition<DataBase.SETOP.Brand> condition =
                    new MSSQLCondition<DataBase.SETOP.Brand>(models, DtWrapper.index, DtWrapper.length);

                DtWrapper.order?.ToList().ForEach(x =>
                {
                    condition.OrderBy(DtWrapper.columns[x.column].name, x.dir);
                });

                var pageList = _repo.GetPaging(condition);

                var ui = pageList.Select(x => new BrandListViewModel(x));

                result = new DataTableRespModel<BrandListViewModel>(ui)
                {
                    recordsTotal = pageList.TotalCount,
                    recordsFiltered = pageList.TotalCount
                };

                return Json(result);
            }
            catch (Exception ex)
            {

                _logger.Error(ex);
                return new JsonResult()
                {
                    Data = new JsonResult<Boolean>(false, $"品牌通路主檔-清單畫面載入失敗 , 原因 : { ex.Message }")
                };
            }

        }

        [HttpPost]
        public ActionResult Remove(int[] IDs)
        {
            try
            {
                MSSQLCondition<DataBase.SETOP.Brand> condition = new MSSQLCondition<DataBase.SETOP.Brand>(x => IDs.Contains(x.ID));

                condition.IncludeBy(x => x.ActivityItem);
                condition.IncludeBy(x => x.Banner);
                condition.IncludeBy(x => x.Item);

                Boolean isSuccess = _repo.Remove(condition);

                return new JsonResult()
                {
                    Data = new JsonResult<Boolean>(true, $"品牌通路主檔-刪除成功")
                };

            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return new JsonResult()
                {
                    Data = new JsonResult<Boolean>(false, $"品牌通路主檔-刪除失敗 , 原因 : { ex.Message }")
                };
            }
        }



    }
}