using System.Xml.Serialization;

namespace MpzMail.Api.Model.Base
{
    [XmlRoot("xml")]
    public class BaseRequest
    {
        [XmlElement("apiKey")]
        public string ApiKey { get; set; }
    }
}
