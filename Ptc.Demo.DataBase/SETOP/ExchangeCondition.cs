//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ptc.Demo.DataBase.SETOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExchangeCondition
    {
        public string ActivityItemCode { get; set; }
        public int ExchangeType { get; set; }
        public Nullable<int> ExchangePoint { get; set; }
        public Nullable<decimal> ExchangeCash { get; set; }
        public Nullable<int> ReaminingQty { get; set; }
        public int ActivityItemType { get; set; }
        public string LastUpdateUserName { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
        public Nullable<int> ExchangedQty { get; set; }
        public int PointType { get; set; }
        public string ExchangeContent { get; set; }
    
        public virtual ActivityItem ActivityItem { get; set; }
    }
}
