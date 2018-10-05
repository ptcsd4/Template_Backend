using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Menu
{
    public class MenuNode
    {
        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        public string TitleName { get; set; }

        public string Description { get; set; }
    }
}
