using System.Net;
using HttpClient = System.Net.Http.HttpClient;

namespace TelasiFetcher.App.Services;

public class HttpService
{
    public string DownloadHtml(string url)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Headers =
            {
                {"Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9"},
                {"User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36"}
            }
        };

        var response = client.SendAsync(request).Result;
        return response.Content.ReadAsStringAsync().Result;
    }
}