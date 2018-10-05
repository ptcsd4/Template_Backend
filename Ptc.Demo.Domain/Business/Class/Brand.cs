using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Business.Class
{
    public class Brand
    {
     
        public int ID { get; set; }

        public string Name { get; set; }

        public string eShopName { get; set; }
      
        public DateTime StartDate { get; set; }

        public string Tel { get; set; }

        public string Url { get; set; }
        public string eShopURL { get; set; }

        public Boolean IsDisabled { get; set; }

        public Boolean IsHaveStore { get; set; }

        public string OPExchangeState { get; set; }

        public string Notice { get; set; }

        public string ActivityNotice { get; set; }

        public int Sort { get; set; }

        public string XLImageFileName { get; set; }

        public string SImageFileName { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public string LastUpdateUserName { get; set; }

    }
}
