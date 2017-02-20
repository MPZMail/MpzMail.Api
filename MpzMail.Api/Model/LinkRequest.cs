using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class LinkRequest : BaseRequest
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("trackingType")]
        public TrackingType TrackingType { get; set; }
        [XmlElement("fromDate")]
        public string FromDate { get; set; }
        [XmlElement("toDate")]
        public string ToDate { get; set; }
    }
}
