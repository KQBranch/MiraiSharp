namespace MiraiSharp.Library.Mirai.Maven
{
    class LinkHelper
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

        public static string GetDownloadLink(string g, string a, string v, LocationEnum location = LocationEnum.ChinaMainland, string extension = ".jar")
        {
            //net/mamoe/mirai-core-all/2.4.0/mirai-core-all-2.4.0-all.jar
            return GetMavenCentralLink(location) + 
                g.Replace(".", "/") + "/" +       // net/mamoe/
                a + "/" +                         // mirai-core-all/
                v + "/" +                         // 2.4.0/
                a + "-" + v + "-all" +            // mirai-core-all-2.4.0-all
                extension;                        // mirai-core-all-2.4.0-all.jar
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
