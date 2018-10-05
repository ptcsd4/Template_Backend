using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Menu
{
    public static class MenuRootsData
    {

        public static List<MenuPrefixNode> Default()
        {
            List<MenuPrefixNode> rootColl = new List<MenuPrefixNode>()
            {

                new MenuPrefixNode()
                {
                    Description = "我的首頁",
                    Id = "home",
                    Name = "首頁",
                    ParentName = string.Empty,
                    IconCss = "icon-star-half-full",
                }
                
            };

            return rootColl;

        }
    }
}
