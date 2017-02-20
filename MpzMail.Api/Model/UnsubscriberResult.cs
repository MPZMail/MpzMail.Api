using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class UnsubscriberResult : BaseResult
    {
        [XmlElement("campaignCnt")]
        public int Count { get; set; }
        [XmlArray("unsubscribers")]
        [XmlArrayItem(ElementName = "unsubscriber")]
        public List<CampaignSubscriber> Subscribers { get; set; }
    }
}
