using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignSubscriberResult : BaseResult
    {
        [XmlElement("subscriberCnt")]
        public int Count { get; set; }
        [XmlArray("subscribers")]
        [XmlArrayItem(ElementName = "subscriber")]
        public List<CampaignSubscriber> Subscribers { get; set; }
    }
}
