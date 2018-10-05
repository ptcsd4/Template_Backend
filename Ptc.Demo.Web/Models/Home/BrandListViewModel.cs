using Ptc.Demo.Domain.Business.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.Models
{
    public class BrandListViewModel : IDataTablePayload
    {
        public BrandListViewModel(Brand Brand)
        {
            this.ID = Brand.ID;
            this.Name = Brand.Name;
            this.StartDate = Brand.StartDate.ToString("yyyy/MM/dd");
            this.IsDisabled = Brand.IsDisabled ? "停用" : "啟用";
            this.IsHaveStore = Brand.IsHaveStore ? "含" : "不含";
            this.Sort = Brand.Sort;

            this.Column = new string[] {
                this.ID.ToString() ,
                this.Sort.ToString() ,
                this.Name,
                this.StartDate,
                this.IsDisabled,
                this.IsHaveStore,
                this.ID.ToString()
            };

        }


        public int ID { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string IsDisabled { get; set; }

        public string IsHaveStore { get; set; }

        public int Sort { get; set; }

        public string[] Column { get; set; }


    }
}