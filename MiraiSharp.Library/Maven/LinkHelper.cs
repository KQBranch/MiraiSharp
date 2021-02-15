namespace MiraiSharp.Library.Mirai.Maven
{
    public class LinkHelper
    {
        private const string MAVEN_CENRRAL_CN = "https://maven.aliyun.com/repository/central/";
        private const string MAVEN_CENTRAL_OUT = "https://repo1.maven.org/maven2/";

        public static string GetMavenCentralLink(LocationEnum location)
        {
            switch (location)
            {
                case LocationEnum.ChinaMainland:
                    return MAVEN_CENRRAL_CN;
                default:
                    return MAVEN_CENTRAL_OUT;
            }
        }

        // FIXME: MAY NOT WORK IN CHINA
        public static string GetInfoLink(string g, string a, string core = "gav", int start = 0, int rows = 20)
        {
            // https://search.maven.org/solrsearch/select?q=
            // g:net.mamoe
            // %20AND%20
            // a:mirai-core-all&core=gav&start=0&rows=5
            return "https://search.maven.org/solrsearch/select?q=" + 
                "g:" + g +
                "%20AND%20" +
                "a:" + a +
                "&core=" + core +
                "&start=" + start +
                "&rows=" + rows;
        }

        public static string GetDownloadLink(string g, string a, string v, LocationEnum location = LocationEnum.ChinaMainland, string extension = ".jar")
        {
            //net/mamoe/mirai-core-all/2.4.0/mirai-core-all-2.4.0-all.jar
            return GetMavenCentralLink(location) + // Base url
                g.Replace(".", "/") + "/" +        // net/mamoe/
                a + "/" +                          // mirai-core-all/
                v + "/" +                          // 2.4.0/
                a + "-" + v + "-all" +             // mirai-core-all-2.4.0-all
                extension;                         // mirai-core-all-2.4.0-all.jar
        }

        public static string GetDownloadLink(string id, string extension = ".jar", LocationEnum location = LocationEnum.ChinaMainland)
        {
            // id -> net.mamoe:mirai-core-all:2.4.0
            // query -> net/mamoe/mirai-core-all/2.4.0/mirai-core-all-2.4.0-all.jar

            string[] info = id.Split(':');
            // [0] G -> net.mamoe
            // [1] A -> mirai-core-all
            // [2] V -> 2.4.0
            return GetDownloadLink(info[0], info[1], info[2], location, extension);
        }
    }
}
