using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class FileRequest
    {
        [XmlElement("fileExtension")]
        public string Extension { get; set; }
        [XmlElement("base64")]
        public string ImageBase64 { get; set; }
    }
}
