using Newtonsoft.Json;

namespace API_Consumer.API
{
    internal class GetData
    {
        public static T getApiData<T>(string url, string id = "", bool cache = false)
        {
            string resultJson = CallApiService(url);

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;

            T obj;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(resultJson, settings);
            }
            catch
            {
                throw;
            }
            return obj;
        }

        private static string CallApiService(string url)
        {
            WS ws = new WS();
            return ws.CallAPIWithResponse(url);
        }

        private static void SaveJsonToFile(string json)
        {

        }

        private static void ReadJsonFromFile()
        {

        }
    }
}