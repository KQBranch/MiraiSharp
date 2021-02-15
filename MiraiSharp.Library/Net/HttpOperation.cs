using System;
using System.Net.Http;

namespace MiraiSharp.Library.Net
{
    class HttpOperation
    {
        public static void Initialize()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5),
            };
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
                "AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/88.0.4324.150 Safari/537.36");
        }

        private static HttpClient _httpClient;

        [Obsolete("Have Not Implemented！")]
        public static string Get(string url)
        {
            throw new NotImplementedException();
        }

        [Obsolete("Have Not Implemented！")]
        public static string Post(string url)
        {
            throw new NotImplementedException();
        }
    }
}
