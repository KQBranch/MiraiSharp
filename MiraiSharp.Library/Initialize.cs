namespace MiraiSharp.Library
{
    public class Initialize
    {
        public static void Do()
        {
            Net.HttpOperation.Initialize();
            IO.Path.Initialize();
        }
    }
}
