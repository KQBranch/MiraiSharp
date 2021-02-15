using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiraiSharp.Library.Mirai
{
    public class DownloadComponents
    {
        static Dictionary<string, string> _components = new Dictionary<string, string>
        {
            { "mirai-core-all","net.mamoe"},
            { "mirai-console-terminal", "net.mamoe"},
            { "mirai-console", "net.mamoe"},
        };

        public static void Start(string version)
        {
            foreach (var kv in _components)
            {
                System.Console.WriteLine("BEGIN [" + kv.Key + "]");
                var link = Maven.LinkHelper.GetDownloadLink(
                    Maven.LinkHelper.MavenTarget.JCenter,
                        kv.Value,
                        kv.Key,
                        version
                        );

                System.Console.WriteLine(link);

                MultiDownload md = new MultiDownload(
                    -1,
                    link,
                    System.IO.Path.Combine("libs", kv.Key) + ".jar");
                md.Start();
                while (!md.IsComplete)
                {
                    System.Console.WriteLine(
                        md.ThreadNum + "    " +
                        "" + md.DownloadSize +
                        "/" + md.FileSize + "    " +
                        100.0 * md.DownloadSize / md.FileSize + "%");
                    Task.Run(() => { System.Threading.Thread.Sleep(500); }).Wait();
                }
                System.Console.WriteLine("COMPLELE [" + kv.Key + "]");

            }
        }
    }
}
