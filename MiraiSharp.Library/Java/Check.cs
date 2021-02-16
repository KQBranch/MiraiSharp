using System.Diagnostics;

namespace MiraiSharp.Library.Java
{
    public class Check
    {
        public static string GetJavaInfo()
        {
            Process p = new Process();
            p.StartInfo.FileName = "java.exe";
            p.StartInfo.Arguments = "-version";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            return p.StandardError.ReadToEnd();
        }

        private static double ConvertJavaBuildByNum(string version)
        {
            for (int l = 3; l > 0; --l)
            {
                string v = version.Substring(0, l);
                if (double.TryParse(v, out double d))
                {
                    return d;
                }
            }
            return -1;
        }

        public static bool IsVersionOver(string version)
        {
            double currentJRE = ConvertJavaBuildByNum(GetJavaBuild());
            if (currentJRE < 0)
                return false;
            double v = ConvertJavaBuildByNum(version);
            return currentJRE >= v;
        }

        public static string GetJavaBuild()
        {
            string[] result = GetJavaInfo().Split('\n');
            foreach (string r in result)
            {
                string[] s = r.Split("build");

                if (s.Length != 2)
                    continue;
                string p = s[1].Trim();
                return p.Substring(0, p.Length - 1);

            }
            return null;
        }

        public static bool IsJavaInstalled()
        {
            string result = GetJavaInfo();
            return result.Contains("build");
        }
    }
}
