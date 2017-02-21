using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignRequest : BaseRequest
    {
        [XmlElement("fromDate")]
        public DateTime FromDate { get; set; }
        [XmlElement("toDate")]
        public DateTime ToDate { get; set; }
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
    }
}
