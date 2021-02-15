using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiraiSharp.Library.Net
{
    public class HttpOperation
    {
        public static void Initialize()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5),
            };
            /*
             _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
                "AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/88.0.4324.150 Safari/537.36");
            */
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Apache-Maven/3.3.9 (Java 1.8.0_121; Windows 10 10.0)");
        }

        private static HttpClient _httpClient;

        public static async Task<string> GetStrAsync(string url)
        {
            HttpResponseMessage hrm = await _httpClient.GetAsync(url);
            return await hrm.Content.ReadAsStringAsync();
        }

        [Obsolete("Have Not Implemented！")]
        public static async Task<string> PostAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}
