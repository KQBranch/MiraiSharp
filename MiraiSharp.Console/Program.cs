using MiraiSharp.Library;

namespace MiraiSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize.Do();
            MiraiSharp.Library.Mirai.DownloadComponents.Start("2.2.2");

            System.Console.ReadKey();
        }
    }
}
