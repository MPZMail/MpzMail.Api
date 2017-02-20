using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SubscriberAddResultModel
    {
        [XmlElement("error")]
        public Status Status { get; set; }
        [XmlElement("status")]
        public string Message { get; set; }
        [XmlElement("subscriberID")]
        public int Id { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
    }
}
