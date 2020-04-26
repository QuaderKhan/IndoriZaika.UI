using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IndoriZaika.Utilities
{
    public class ServiceInvoker
    {
        static readonly HttpClient client;
        static string results;
        static ServiceInvoker()
        {
            client = new HttpClient();
        }

        public static string GetServiceResults(string serviceUrl)
        {
            HttpResponseMessage response = client.GetAsync(serviceUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                results = response.Content.ReadAsStringAsync().Result;
            }
            else
                results = response.StatusCode.ToString();
            return results;
        }
    }
}
