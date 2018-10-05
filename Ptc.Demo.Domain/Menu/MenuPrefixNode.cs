using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Menu
{
    public class MenuPrefixNode : MenuNode
    {
        public string ParentName { get; set; }

        public List<MenuPrefixNode> Child { get; set; }

        public List<MenuControllerNode> MenuNodeCollection { get; set; }

        public string IconCss { get; set; }

        public MenuPrefixNode ToTree(List<MenuPrefixNode> PrefixNode, List<MenuControllerNode> EntryControllerNode)
        {
            this.Child = RecursiveChildToTree(PrefixNode, ref EntryControllerNode, this.Name);
            return this;
        }

        private List<MenuPrefixNode> RecursiveChildToTree(List<MenuPrefixNode> PrefixNode, ref List<MenuControllerNode> EntryControllerNode, string Name)
        {

            List<MenuPrefixNode> children = PrefixNode.Where(x => x.ParentName == Name).ToList();

            if (this.MenuNodeCollection == null)
                this.MenuNodeCollection = new List<MenuControllerNode>();


            List<MenuControllerNode> controllNode = EntryControllerNode.Where(x => x.PrefixedNodeID == this.Id).ToList();

            foreach (var node in controllNode)
            {
                node.BindFlag = true;
                this.MenuNodeCollection.Add(node);
            }


            if (children.Count == 0) return null;


            foreach (var item in children)
            {
                item.Child = item.RecursiveChildToTree(PrefixNode, ref EntryControllerNode, item.Name);
            }

            //將未定義之功能顯示在ROOT節點上
            if (this.MenuNodeCollection.Count > 0)
            {
                List<string> tmp = this.MenuNodeCollection.Select(x => x.ControllerName).ToList();
                List<MenuControllerNode> nouse = EntryControllerNode.Where(x => !x.BindFlag && tmp.Contains(x.ControllerName)).ToList();

                if (nouse.Count() > 0) this.MenuNodeCollection.AddRange(nouse);
            }

            return children;
        }
        public override string ToString()
        {
            return base.Name;

        
        }

    }
}
