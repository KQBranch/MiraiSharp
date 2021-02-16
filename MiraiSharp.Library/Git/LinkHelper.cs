namespace MiraiSharp.Library.Git
{
    class LinkHelper
    {
        private const string GITEE_RAW = "https://gitee.com/";
        private const string GITHUB_RAW = "https://raw.githubusercontent.com/";

        public static string GetRawLink(GitEnum ge, string author, string repo, string path,
            string branch="master")
        {
            // https://gitee.com/{Author}/{Repo}/raw/{Branch}/{Path}
            // https://raw.githubusercontent.com/{Author}/{Repo}/master/{Path}
            switch (ge)
            {
                case GitEnum.Gitee:
                    return $"{GITEE_RAW}/{author}/{repo}/raw/{branch}/{path}";
                case GitEnum.GitHub:
                    return $"{GITHUB_RAW}/{author}/{repo}/{branch}/{path}";
            }
            return "";
        }

        public static string GetRawLink(GitInfoModel gim)
        {
            gim.Type = "raw";

            return gim.ToString();
        }

    }
}
