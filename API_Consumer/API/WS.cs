using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer
{
    class WS
    {
        public async Task<String> MakePostCall(Uri u)
        {
            HttpResponseMessage response;
            String responseStr = String.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    response = await client.GetAsync(u);
                }

                responseStr = await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Greška prilikom poziva WS.PostAsync metode: " + e.Message);
            }
            return responseStr;
        }

        public String CallAPIWithResponse(String URL)
        {
            String rezultat = String.Empty;
            try
            {
                Uri u = new Uri(URL);
                var t = Task.Run(() => MakePostCall(u));
                t.Wait();

                rezultat = t.Result;
            }
            catch
            {
                throw;
            }

            return rezultat;
        }
    }
}
