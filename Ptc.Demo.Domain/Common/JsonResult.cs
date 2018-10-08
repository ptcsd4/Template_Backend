using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Common
{
    public class JsonResult<T>
    {

        public JsonResult()
        {
        }

        public JsonResult(T Element)
        {
            this.Element = Element;
            this.IsSuccess = true;
        }
        public JsonResult(bool IsSuccess, string Message)
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;

        }
        public JsonResult(T Element, bool IsSuccess)
        {
            this.IsSuccess = IsSuccess;
            this.Element = Element;
        }
        public JsonResult(T Element , bool IsSuccess, string Message)
        {
            this.Element = Element;
            this.IsSuccess = IsSuccess;
            this.Message = Message;

        }


        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public T Element { get; set; }

        public dynamic Extension { get; set; }



    }
}
