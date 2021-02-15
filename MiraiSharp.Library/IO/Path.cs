using System.IO;

namespace MiraiSharp.Library.IO
{
    public class Path
    {
        public static void Create(string[] directories = null, bool isNeedEmpty = false)
        {
            if (directories is null)
            {
                directories = PathText.Directories;
            }

            foreach (string directory in directories)
            {
                if (Directory.Exists(directory) && !isNeedEmpty)
                    continue;

                if (File.Exists(directory))
                {
                    File.Delete(directory);
                }
                else
                {
                    if (Directory.Exists(directory))
                    {
                        Directory.Delete(directory);
                    }
                }
                Directory.CreateDirectory(directory);
            }
        }
    }
}
