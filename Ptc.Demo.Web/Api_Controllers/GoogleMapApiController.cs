using Ptc.Demo.Domain.Common;
using Ptc.Demo.Domain.GoogleMap;
using Ptc.Demo.Domain.Service;
using Ptc.Demo.Service.Profile;
using Ptc.Demo.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ptc.Demo.Web.Api_Controllers
{
    [TokenAuthenticationFilter]
    public class GoogleMapApiController : BaseApiController
    {
        private readonly IGoogleMapProvider _GoogleProvider;

        public GoogleMapApiController(IGoogleMapProvider GoogleMapProvider)
        {
            _GoogleProvider = GoogleMapProvider;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> GetMergedLocationPoint(NearbySearchParameter param)
        {
            var result = await _GoogleProvider.GetFromLocation(param);

            reAssign(result);

            return Request.CreateResponse(HttpStatusCode.OK,
                   new JsonResult<NearbySearchResult>(result, true));

        }

        private void reAssign(NearbySearchResult infoWrapper)
        {

            foreach (var result in infoWrapper.results)
            {
                var preview = result.photos?.FirstOrDefault();
                //找到瀏覽圖
                if (preview != null)
                {
                    result.photo = string.Format(AppProfile.Instance.GoogleMapProfile.GOOGLE_PHOTO_URL_FORMAT,
                        preview.photo_reference,
                        preview.height,
                        preview.width,
                        AppProfile.Instance.GoogleMapProfile.GOOGLE_API_KEY);
                }

                //比對店頭 , 押上註記 is_store

            }
        }
    }
}
