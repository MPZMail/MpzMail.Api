using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberListResult : BaseResult
    {
        [XmlElement("subscriberCnt")]
        public int Count { get; set; }
        [XmlArray("subscribers")]
        [XmlArrayItem("subscriber")]
        public List<SubscriberListResultModel> Subscribers { get; set; }
    }
}
