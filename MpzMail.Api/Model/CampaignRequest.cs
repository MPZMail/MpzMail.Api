using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignRequest : BaseRequest
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("fromDate")]
        public string FromDate { get; set; }
        [XmlElement("toDate")]
        public string ToDate { get; set; }
    }
}
