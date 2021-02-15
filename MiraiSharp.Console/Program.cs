using System;

using MiraiSharp.Library;

namespace MiraiSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize.Do();
            //var s = Library.Maven.MavenHelper.GetMavenInfo("net.mamoe", "mirai-core-all").Result;
            var meta = Library.Net.HttpOperation.GetStrAsync("https://bintray.com/karlatemp/mirai/download_file?file_path=net%2Fmamoe%2Fmirai-login-solver-selenium%2Fmaven-metadata.xml").Result;
            System.Console.WriteLine(meta);
            Library.Maven.Meta.Parser.FromStr(meta);
        }
    }
}
