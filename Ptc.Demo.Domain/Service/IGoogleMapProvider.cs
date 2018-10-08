using Ptc.Demo.Domain.GoogleMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.Service
{
    public interface IGoogleMapProvider
    {
        Task<NearbySearchResult> GetFromLocation(NearbySearchParameter param);

    }
}
