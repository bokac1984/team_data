using Newtonsoft.Json;

namespace API_Consumer.API
{
  internal class GetData
  {
    public static T getApiData<T>(string url)
    {
      WS ws = new WS();
      JsonSerializerSettings settings = new JsonSerializerSettings();
      settings.MissingMemberHandling = MissingMemberHandling.Ignore;
      string str = ws.CallAPIWithResponse(url);
      T obj;
      try
      {
        obj = JsonConvert.DeserializeObject<T>(str, settings);
      }
      catch
      {
        throw;
      }
      return obj;
    }
  }
}