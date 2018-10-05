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
    
    public partial class ActivityItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityItem()
        {
            this.ActivityItem1 = new HashSet<ActivityItem>();
            this.ActivityItemVoucher = new HashSet<ActivityItemVoucher>();
            this.ExchangeCondition = new HashSet<ExchangeCondition>();
            this.OpenPointMemberStar = new HashSet<OpenPointMemberStar>();
            this.Banner = new HashSet<Banner>();
        }
    
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string PICPointSystemCode { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<System.DateTime> ExchangeEndDate { get; set; }
        public Nullable<System.DateTime> LotteryDrawingDate { get; set; }
        public int ActivityItemType { get; set; }
        public int ParentItemType { get; set; }
        public int CardType { get; set; }
        public int CollectType { get; set; }
        public int TargetType { get; set; }
        public int PointType { get; set; }
        public int StockShowType { get; set; }
        public int VerifyType { get; set; }
        public int EachExchangeLimitQty { get; set; }
        public int MemberExchangeLimitQty { get; set; }
        public int PackQty { get; set; }
        public int PackageDailyQty { get; set; }
        public Nullable<int> StarQty { get; set; }
        public Nullable<int> SystemTopStort { get; set; }
        public Nullable<int> KeyInTopSort { get; set; }
        public bool OutOfStockNotShow { get; set; }
        public Nullable<bool> IsTimeLimited { get; set; }
        public bool IsEShop { get; set; }
        public bool IsFirstGift { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public int BrandID { get; set; }
        public string BankCode { get; set; }
        public string CoBranderCheckCode { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string ItemCode { get; set; }
        public string Keyword { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public string LimitedExchangeTimesDescription { get; set; }
        public string Description { get; set; }
        public string Notice { get; set; }
        public string Specification { get; set; }
        public string DiscountCondition1 { get; set; }
        public string DiscountCondition2 { get; set; }
        public string XLImageFileName { get; set; }
        public string SImageFileName { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
        public string LastUpdateUserName { get; set; }
        public System.DateTime CreateUpdateTime { get; set; }
        public string CreateUpdateUserName { get; set; }
        public string RewardID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityItem> ActivityItem1 { get; set; }
        public virtual ActivityItem ActivityItem2 { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Item Item { get; set; }
        public virtual RewardActivity RewardActivity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityItemVoucher> ActivityItemVoucher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeCondition> ExchangeCondition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenPointMemberStar> OpenPointMemberStar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banner> Banner { get; set; }
    }
}
