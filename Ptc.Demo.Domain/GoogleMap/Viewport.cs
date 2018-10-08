using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class Viewport
    {
        public Viewport() { }

        public Coordinate northeast { get; set; }

        public Coordinate southwest { get; set; }
    }
}
