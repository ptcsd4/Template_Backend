using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Profile
{
    public class ProfileSource : Attribute
    {
        public bool IsFromDB { get; set; }

        public bool IsObject { get; set; } = false;
    }
}
