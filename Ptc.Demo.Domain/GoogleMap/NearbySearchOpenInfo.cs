using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class NearbySearchOpenInfo
    {
        public NearbySearchOpenInfo()
        {
        }
        public Boolean open_now { get; set; }

        public string[] weekday_text { get; set; }
    }
}
