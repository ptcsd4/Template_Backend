using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class NearbySearchResult
    {
        public NearbySearchResult() { }
        public string next_page_token { get; set; }
        public string error_message { get; set; }
        public NearbySearchLocation[] results { get; set; }
    }
}
