# IP2Location.cs
Web-API for [ip2location.io](https://www.ip2location.io) that provides a fast and accurate IP Geolocation API tool to determine a user's location and use the geolocation information in different use cases

## Example
```cs
using IP2LocationApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IP2Location();
            api.SetApiKey("apiKey");
            string ipInfo = await api.GetIpInfo("192.168.1.1");
            Console.WriteLine(ipInfo);
        }
    }
}
```
