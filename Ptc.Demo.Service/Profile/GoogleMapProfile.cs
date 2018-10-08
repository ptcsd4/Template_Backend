using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Profile
{
    public class GoogleMapProfile
    {
        private static readonly Lazy<GoogleMapProfile> LazyInstance = new Lazy<GoogleMapProfile>(() => new GoogleMapProfile());

        private GoogleMapProfile() { }

        public static GoogleMapProfile Instance { get { return LazyInstance.Value; } }


        public string GOOGLE_PLACE_API_URL_HOST { get; set; } = "https://maps.googleapis.com/";

        public string NEARBY_SEARH_URL { get; set; } = "maps/api/place/nearbysearch/json";

        public string LOCATION_DETAIL_SEARH_URL { get; set; } = "maps/api/place/details/json";

        public string GOOGLE_API_KEY { get; set; } = "AIzaSyChJgnSMlEe2Ue0jD2goECR9RDJsAWEOd4";

        public string GOOGLE_PHOTO_URL_FORMAT { get; set; } = "https://maps.googleapis.com/maps/api/place/photo?photoreference={0}&sensor=false&maxheight={1}&maxwidth={2}&key={3}";

        public int NEARBY_SEARCH_REDIUS { get; set; } = 5000;

        public string GOOGLE_API_LANGULAGE = "zh-TW";
    }
}
