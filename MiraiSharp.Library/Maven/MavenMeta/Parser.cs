using System.IO;
using System.Xml.Serialization;

namespace MiraiSharp.Library.Maven.Meta
{
    public class Parser
    {
        public static MavenMetadataModel FromStr(string str)
        {
            using StringReader sr = new StringReader(str);
            XmlSerializer xz = new XmlSerializer(typeof(MavenMetadataModel));
            return (MavenMetadataModel)xz.Deserialize(sr);
        }
    }
}
