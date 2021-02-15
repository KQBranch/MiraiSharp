using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiraiSharp.Library.Maven
{
    public class MavenHelper
    {
        public static async Task<MavenModel> GetMavenInfo(string g, string a)
        {
            string searchLink = LinkHelper.GetInfoLink(g, a);
            string content;
            try
            {
                content = await Net.HttpOperation.GetStrAsync(searchLink);
            }
            catch (Exception ex)
            {
                // FIXME: DO IN EX
                return null;
            }
            MavenModel jo = JsonSerializer.Deserialize<MavenModel>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            return jo;
        }
    }
}
