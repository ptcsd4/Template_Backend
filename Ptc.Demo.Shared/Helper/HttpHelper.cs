using Newtonsoft.Json;
using Ptc.Demo.Shared.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ptc.Demo.Shared.Helper
{
    public class HttpHelper
    {
        private int Port = -1;
        private string Host = "";
        private string Path = "";


        public HttpHelper(string Host, string Path)
        {
            this.Host = Host;
            this.Path = Path;
        }

        public HttpHelper(string Host, int Port, string Path)
        {
            this.Host = Host;
            this.Port = Port;
            this.Path = Path;
        }
        public async Task<TResult> GetAsync<TValue, TResult>(TValue Value)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var response = await client.GetAsync(ToURL(Value));

                    response.EnsureSuccessStatusCode();

                    string result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<TResult>(result);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public async Task<TResult> PostAsync<TValue, TResult>(TValue Value)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var encodedContent = new FormUrlEncodedContent(Value.ParseObjectToKeyValue());

                    var response = await client.PostAsync(ToBuilder().ToString(), encodedContent);

                    response.EnsureSuccessStatusCode();

                    string result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<TResult>(result);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private UriBuilder ToBuilder()
        {
            if (string.IsNullOrEmpty(Host)) throw new ArgumentException("api path not be null");

            var builder = new UriBuilder(Host);

            builder.Port = Port;
            builder.Path = Path;

            return builder;
        }
        private string ToQuery(object Value)
        {


            var pairs = Value.ParseObjectToKeyValue();

            string query = String.Join("&", pairs.Keys.Select(v => v + "=" + HttpUtility.UrlEncode(pairs[v])));

            return query;
        }
        private string ToURL(object Value)
        {

            var builder = ToBuilder();

            builder.Query = ToQuery(Value);

            return builder.ToString();

        }
    }
}
