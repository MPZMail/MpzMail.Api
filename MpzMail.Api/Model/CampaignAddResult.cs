using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignAddResult : BaseResult
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("totalSubscribers")]
        public int TotalSubscribers { get; set; }
    }
}
