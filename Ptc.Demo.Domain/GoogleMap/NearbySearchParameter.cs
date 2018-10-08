using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class NearbySearchParameter
    {

        public NearbySearchParameter() { }

        /// <summary>
        /// 您應用程式的 API 金鑰。此金鑰可識別您的應用程式來進行配額管理，
        /// 並且讓您的應用程式能夠立即使用從您的應用程式新增的地點。如需詳細資訊，請參閱取得金鑰。
        /// </summary>
        public string key { get; set; }
        /// <summary>
        ///  用來擷取其周圍地點資訊的緯度/經度。這必須以「緯度,經度」的方式指定。
        /// </summary>
        public string location { get; set; }
        /// <summary>
        ///  定義要傳回地點結果的距離範圍（單位為公尺）。允許的最大半徑是 50,000 公尺。請注意，如果已指定 
        /// </summary>
        public int radius { get; set; }
        /// <summary>
        /// 要與 Google 已為此地點建立索引的所有內容（包括但不限於名稱、類型和地址）比對，以及與客戶評論和其他第三方內容比對的字詞。
        /// </summary>
        public string keyword { get; set; }
        /// <summary>
        /// 指定列出結果的順序。請注意，如果已指定 radius （參見上文必要參數），則不應該包含 rankby。可能的值包括： 
        ///prominence （預設）。此選項會根據結果的重要性進行排序。排名會以指定區域內的高知名度地點為優先。知名度會受到地點在 Google 索引中的排名、全球熱門度及其他因素影響。 
        ///distance。此選項會依據與所指定 location 的距離，以遞增順序將搜尋結果排序。已指定 distance 時，必須指定 keyword、name 或 type 其中一或多個參數。
        /// </summary>
        public string rankby { get; set; }
        /// <summary>
        /// 將結果限制在與指定類型相符的地點。
        /// 只能指定一種類型（如果超過一種類型，第一個項目之後的所有類型都會被忽略）。請參閱支援的類型清單。
        /// </summary>
        public string type { get; set; } = LocationType.restaurant.ToString();
        /// <summary>
        /// 支援語言
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// 分頁查詢權杖
        /// </summary>
        public string pagetoken { get; set; }
        /// <summary>
        /// 經度
        /// </summary>
        public double lng { get; set; }
        /// <summary>
        /// 緯度
        /// </summary>
        public double lat { get; set; }

        public string getLocation()
        {
            return $"{ this.lat.ToString() },{this.lng.ToString()}";
        }

    }
}
