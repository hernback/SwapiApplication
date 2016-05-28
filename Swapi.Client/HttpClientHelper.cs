using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;

namespace Swapi.Client
{
    public static class HttpClientHelper
    {
        public static string RunHttpClientSyncCall(string baseAddress, string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    return result.Result;
                }
            }
            return string.Empty;
        }
    }
}
