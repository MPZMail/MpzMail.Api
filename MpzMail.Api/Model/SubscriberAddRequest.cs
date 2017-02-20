using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberAddRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("returnAllFields")]
        public bool? ReturnCustomFields { get; set; }
        [XmlArray("subscribers")]
        [XmlArrayItem("subscriber")]
        public List<SubscriberAddRequestModel> Subscribers { get; set; }
    }
}
