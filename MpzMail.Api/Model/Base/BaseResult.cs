using System.Xml.Serialization;

namespace MpzMail.Api.Model.Base
{
    [XmlRoot("xml")]
    public class BaseResult
    {
        [XmlElement("error")]
        public Status Status { get; set; }
        [XmlElement("status")]
        public string Message { get; set; }
    }
}
