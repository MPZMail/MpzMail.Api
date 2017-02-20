using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberAddResult : BaseResult
    {
        [XmlArray("subscribers")]
        [XmlArrayItem("subscriber")]
        public List<SubscriberAddResultModel> Subscribers { get; set; }
    }
}
