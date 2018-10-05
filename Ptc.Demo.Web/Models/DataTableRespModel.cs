using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.Models
{
    public class DataTableRespModel<T> where T :  IDataTablePayload  
    {

        public DataTableRespModel()
        {

        }

       
        public DataTableRespModel(IEnumerable<T> payload)
        {
            this.data = payload?.Select(x => x.Column).ToArray();
        }

        /// <summary>
        /// 等同查詢要求(request)的draw數
        /// </summary>
        public int draw { get; set; }

        /// <summary>
        /// 查詢結果總筆數
        /// </summary>
        public int recordsTotal { get; set; }

        /// <summary>
        /// 查詢結果筆數(分頁後)
        /// </summary>
        public int recordsFiltered { get; set; }

        /// <summary>
        /// 查詢結果資料
        /// </summary>
        public string[][] data { get; set; }

        /// <summary>
        /// 非必要欲回傳的錯誤資訊
        /// </summary>
        public string error { get; set; }

        /// <summary>
        /// 擴充欄位
        /// </summary>
        public object extend { get; set; }
    }
}