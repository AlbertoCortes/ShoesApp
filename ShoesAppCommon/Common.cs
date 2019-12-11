using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesAppCommon
{
    public class Common
    {
        public static Out SerializeJson<In, Out>(In obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Out>(output);
        }
    }
}
