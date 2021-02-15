using System;

using MiraiSharp.Library;

namespace MiraiSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize.Do();
            var s = Library.Maven.MavenHelper.GetMavenInfo("net.mamoe", "mirai-core-all").Result;
        }
    }
}
