using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Menu
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class MenuNodeAttribute : Attribute
    {

        public MenuNodeAttribute()
        {

        }

        public string PrefixedNodeID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ActionName { get; set; }

        public bool IsEntry { get; set; }

        public string GroupName { get; set; }

        public int Id { get; set; }

    }
}
