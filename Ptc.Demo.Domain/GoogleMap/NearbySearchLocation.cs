using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class NearbySearchLocation
    {

        public Geometry geometry { get; set; }

        public string icon { get; set; }

        public string id { get; set; }

        public string name { get; set; }

        public NearbySearchOpenInfo opening_hours { get; set; }

        public NearbySearchPhoto[] photos { get; set; }

        public string place_id { get; set; }

        public string reference { get; set; }

        public string scope { get; set; }

        public decimal rating { get; set; }

        public string[] types { get; set; }

        public string vicinity { get; set; }

        public bool is_store { get; set; }

        public string photo { get; set; }
    }
}
