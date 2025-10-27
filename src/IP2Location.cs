using System.Net.Http;
using System.Net.Http.Headers;

namespace IP2LocationApi
{
    public class IP2Location
    {
        private string apiKey;
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.ip2location.io";
        public IP2Location()
        {

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void SetApiKey(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<string> GetIpInfo(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/?key={apiKey}&ip={ip}&format=json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
