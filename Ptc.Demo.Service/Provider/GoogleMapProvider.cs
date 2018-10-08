using Ptc.Demo.Domain.GoogleMap;
using Ptc.Demo.Domain.Service;
using Ptc.Demo.Service.Profile;
using Ptc.Demo.Shared.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Provider
{
    public class GoogleMapProvider : IGoogleMapProvider
    {

        public async Task<NearbySearchResult> GetFromLocation(NearbySearchParameter param)
        {

            var wrapper = await new HttpHelper(AppProfile.Instance.GoogleMapProfile.GOOGLE_PLACE_API_URL_HOST,
                                               AppProfile.Instance.GoogleMapProfile.NEARBY_SEARH_URL)
               .GetAsync<NearbySearchParameter, NearbySearchResult>(new NearbySearchParameter()
               {
                   key = AppProfile.Instance.GoogleMapProfile.GOOGLE_API_KEY,
                   radius = AppProfile.Instance.GoogleMapProfile.NEARBY_SEARCH_REDIUS,
                   language = AppProfile.Instance.GoogleMapProfile.GOOGLE_API_LANGULAGE,
                   type = param.type,
                   location = param.getLocation(),                
                   keyword = param.keyword,
                   pagetoken = param.pagetoken,
               });


            ////持續嘗試取得
            //if (!string.IsNullOrEmpty(wrapper.error_message)) {
            //    Thread.Sleep(1000);
            //    return await this.GetFromLocation(param);
            //}


            return wrapper;
        }
    }
}
