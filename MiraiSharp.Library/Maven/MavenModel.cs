using System.Collections.Generic;

namespace MiraiSharp.Library.Maven
{
    public class MavenModel
    {
        public ResponseHeaderModel ResponseHeader { get; set; }

        public ResponseModel Response { get; set; }

        public class ResponseHeaderModel
        {
            public int Status { get; set; }
        }
        public class ResponseModel
        {
            public int NumFound { get; set; }
            public List<DocsModel> Docs { get; set; }
            public class DocsModel
            {
                public string ID { get; set; }
                public string G { get; set; }
                public string A { get; set; }
                public string V { get; set; }
                public List<string> EC { get; set; }
            }
        }
    }

    public static class MavenModelExtensionMethods
    {
        public static string GetDownloadLink(this MavenModel.ResponseModel.DocsModel doc, LocationEnum location = LocationEnum.ChinaMainland, string extension = ".jar")
        {
            // Check is extension inside EC
            string ec = extension;
            if (ec.EndsWith(".md5"))
            {
                ec.Substring(0, extension.Length - 4);
            }

            if (doc.EC.Contains(ec))
                return LinkHelper.GetDownloadLink(doc.G, doc.A, doc.V, location, extension);
            return "";
        }
    }
}
