using System.Collections.Generic;
using System.Xml.Serialization;

namespace MiraiSharp.Library.MavenMeta
{
    [XmlRoot("metadata")]
    public class MavenMetadataModel
    {
        [XmlElement("groupId")]
        public string GroupId { get; set; }

        [XmlElement("artifactId")]
        public string ArtifactId { get; set; }

        [XmlElement("versioning")]
        public VersioningModel Versioning { get; set; }

        public class VersioningModel
        {
            [XmlElement("latest")]
            public string Latest { get; set; }

            [XmlElement("release")]
            public string Release { get; set; }

            [XmlArray("versions")]
            [XmlArrayItem("version")]
            public List<string> Versions { get; set; }

            [XmlElement("lastUpdated")]
            public string LastUpdated { get; set; }

        }
    }
}
