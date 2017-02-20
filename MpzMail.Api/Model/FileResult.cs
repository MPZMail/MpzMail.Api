using System.Xml.Serialization;

namespace MpzMail.Api.Model.Base
{
    public class FileResult
    {
        [XmlElement("shortName")]
        public string ShortName { get; set; }
        [XmlElement("fullPath")]
        public string FullPath { get; set; }
    }
}
