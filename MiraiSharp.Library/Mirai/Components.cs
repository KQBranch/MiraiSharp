using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiraiSharp.Library.Mirai
{
    public class Components
    {
        static Dictionary<string, string> _components = new Dictionary<string, string>
        {
            { "mirai-core-all","net.mamoe"},
            { "mirai-console-terminal", "net.mamoe"},
            { "mirai-console", "net.mamoe"},
        };

        public static Task DownloadComponent(string name, string version, string groupId = "net.mamoe")
        => Task.Run(async () =>
        {
        start:
            string path = Path.Combine("libs", name + "-" + version) + ".jar";
            var link = Maven.LinkHelper.GetDownloadLink(
                   Maven.LinkHelper.MavenTarget.JCenter,
                       groupId,
                       name,
                       version
                       );
            MultiDownload md = new MultiDownload(
                    -1,
                    link,
                    path);
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
            ComponentStatusEnum status = await CheckComponent(name, version, groupId);
            if (status != ComponentStatusEnum.Ok && status != ComponentStatusEnum.Unknown)
            {
                File.Delete(path + ".sha1");
                goto start;
            }
        });

        public static async Task Download(string version)
        {
            foreach (var kv in _components)
            {
                System.Console.WriteLine("BEGIN [" + kv.Key + "]");
                await DownloadComponent(kv.Key, version, kv.Value);
                System.Console.WriteLine("COMPLELE [" + kv.Key + "]");
            }
        }

        public static async Task<Dictionary<string, ComponentStatusEnum>> Check(string version)
        {
            Dictionary<string, ComponentStatusEnum> componentStatus = new Dictionary<string, ComponentStatusEnum>();
            foreach (var kv in _components)
            {
                componentStatus.Add(kv.Key, await CheckComponent(kv.Key, version));
            }
            return componentStatus;
        }

        public static async Task<string> DownloadSha1File(string name, string version, string groupId = "net.mamoe")
        {
            string path = Path.Combine("libs", name + ".jar");
            string sha1;
            try
            {
                sha1 = await Net.HttpOperation.GetStrAsync(
                         Maven.LinkHelper.GetDownloadLink(
                             Maven.LinkHelper.MavenTarget.JCenter,
                             groupId,
                             name,
                             version,
                             extension: ".jar.sha1"));
            }
            catch
            {
                sha1 = null;
            }
            if (sha1 != null)
                File.WriteAllText(path + ".sha1", sha1);
            return sha1;
        }

        public static async Task<ComponentStatusEnum> CheckComponent(string name, string version, string groupId = "net.mamoe")
        {
            string path = Path.Combine("libs", name + ".jar");
            if (!File.Exists(path))
            {
                return ComponentStatusEnum.Lost;
            }
            string sha1;
            if (!File.Exists(path + ".sha1"))
            {
                sha1 = await DownloadSha1File(name, version, groupId);
            }
            else
            {
                sha1 = File.ReadAllText(path + ".sha1").Trim();
                if (string.IsNullOrEmpty(sha1))
                {
                    File.Delete(path + ".sha1");
                    return await CheckComponent(name, version, groupId);
                }
            }

            if (string.IsNullOrEmpty(sha1))
                return ComponentStatusEnum.Unknown;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] hashBytes = Cryptography.Shared.Sha1.ComputeHash(fs);
            fs.Close();
            if (sha1.ToLower() != Cryptography.Shared.ConvertByteArrayToHexString(hashBytes).ToLower())
                return ComponentStatusEnum.Broken;
            return ComponentStatusEnum.Ok;
        }
    }
}
