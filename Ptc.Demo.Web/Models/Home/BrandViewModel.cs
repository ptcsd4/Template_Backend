using Ptc.Data.Condition2.Interface.Type;
using Ptc.Data.Condition2.Mssql.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Ptc.Demo.Web.Models
{
    public class BrandViewModel
    {

        [MSSQLFilter("Name",
        ExpressionType.Parameter,
        PredicateType.And)]
        [DisplayName("品牌名稱")]
        [DisplayFormat(NullDisplayText = "請輸入品牌名稱")]
        public string Name { get; set; }

        [MSSQLFilter("IsDisabled",
        ExpressionType.Equal,
        PredicateType.And)]
        [DisplayName("停用")]
        [DisplayFormat(NullDisplayText = "請選擇停用")]
        public bool? IsDisabled { get; set; }

        [MSSQLFilter("IsHaveStore",
        ExpressionType.Equal,
        PredicateType.And)]
        [DisplayName("品牌館")]
        [DisplayFormat(NullDisplayText = "請選擇品牌館")]
        public bool? IsHaveStore { get; set; }


        public List<SelectListItem> DisableList { get; set; } =
            new List<SelectListItem>()
            {
                new SelectListItem() { Text = "全選", Value = null},
                new SelectListItem() { Text = "啟用", Value = "false"},
                new SelectListItem() { Text = "停用", Value = "true"}
            };

        public List<SelectListItem> HaveStoreList { get; set; } =
            new List<SelectListItem>()
            {
                new SelectListItem() { Text = "全選", Value = null},
                new SelectListItem() { Text = "含", Value = "true"},
                new SelectListItem() { Text = "不含", Value = "false"}
            };



    }
}