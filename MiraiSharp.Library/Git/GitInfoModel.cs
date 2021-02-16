using System;

namespace MiraiSharp.Library.Git
{
    class GitInfoModel
    {
        public string Host { get; set; }
        public string Author { get; set; }
        public string Repo { get; set; }
        public string Type { get; set; }
        public string Branch { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            string s = "";
            if (!string.IsNullOrWhiteSpace(Type))
            {
                s = Type + "/" + Branch + "/";
            }
            return $"https://{Host}/{Author}/{Repo}/{Type}{Path}";
        }

        public GitInfoModel() { }
        public GitInfoModel(string url)
        {
            Uri uri = new Uri(url);
            Host = uri.Host;
            string[] query = uri.PathAndQuery.ToLower().Split('/');
            // 0 -> LGBT-CN
            // 1 -> HistoryToday
            // 2 -> blob|raw
            // 3 -> master
            // 4 -> data.json
            if (query.Length < 2)
                throw new ArgumentOutOfRangeException();

            Author = query[0];
            Repo = query[1];
            if (query.Length > 2)
            {
                Branch = query[3];
                Path = string.Join('/', query[4..]);
            }
        }
    }
}
