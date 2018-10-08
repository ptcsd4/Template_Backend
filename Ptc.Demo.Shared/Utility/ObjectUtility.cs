using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Shared.Utility
{
    public static class ObjectUtility
    {

        public static Dictionary<string, string> ParseObjectToKeyValue(this object Object)
        {

            var result = new Dictionary<string, string>();

            var props = Object?.GetType()?.GetProperties()?.ToList();

            props?.ForEach(prop =>
            {
                var name = prop.Name;
                var value = Object.GetType().GetProperty(prop.Name).GetValue(Object, null);
                if (value == null) return;

                if (value is string)
                {
                    result.Add(name, value.ToString());
                }
                else
                {
                    result.Add(name, JsonConvert.SerializeObject(value));
                }
            });

            return result;
        }
    }
}
