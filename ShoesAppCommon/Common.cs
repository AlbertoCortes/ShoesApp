using Newtonsoft.Json;

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
