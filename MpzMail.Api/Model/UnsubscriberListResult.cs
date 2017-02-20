using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class UnsubscriberListResult : BaseResult
    {
        [XmlElement("unsubscriberCnt")]
        public int Count { get; set; }
        [XmlArray("unsubscribers")]
        [XmlArrayItem("unsubscriber")]
        public List<Unsubscriber> Unsubscribers { get; set; }
    }
}
