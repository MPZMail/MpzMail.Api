using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignResult : BaseResult
    {
        [XmlElement("campaignCnt")]
        public int Count { get; set; }
        [XmlArray("campaigns")]
        [XmlArrayItem(ElementName = "campaign")]
        public List<Campaign> Campaigns { get; set; }
    }
}
