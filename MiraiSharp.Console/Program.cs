using MiraiSharp.Library;

namespace MiraiSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize.Do();
            MiraiSharp.Library.Mirai.Components.Download("2.2.2", location: Library.Maven.LocationEnum.Outside).Wait();

            System.Console.ReadKey();
        }
    }
}
