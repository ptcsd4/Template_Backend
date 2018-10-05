using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Menu
{
    public class MenuControllerNode : MenuNode
    {
        public MenuControllerNode()
        {
            this.SubNode = new List<MenuControllerNode>();
        }

        public bool BindFlag { get; set; }


        public String ControllerName { get; set; }

        public string ActionName { get; set; }

        public bool IsEntry { get; set; }

        public string GroupName { get; set; }

        public string PrefixedNodeID { get; set; }

        public List<MenuControllerNode> SubNode { get; set; }

        public override string ToString()
        {
            return string.Format("{0} Group:[{1}]", base.Name, GroupName);

        }
    }
}
