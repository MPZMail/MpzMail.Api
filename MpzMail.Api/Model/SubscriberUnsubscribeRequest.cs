using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberUnsubscribeRequest : BaseRequest
    {
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("returnAllFields")]
        public ReturnAllFields ReturnWithCustomFields { get; set; }
    }
}
