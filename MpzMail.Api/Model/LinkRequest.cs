using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class LinkRequest : BaseRequest
    {
        [XmlElement("fromDate")]
        public DateTime? FromDate { get; set; }
        public bool ShouldSerializeFromDate()
        {
            return FromDate.HasValue;
        }
        [XmlElement("toDate")]
        public DateTime? ToDate { get; set; }
        public bool ShouldSerializeToDate()
        {
            return ToDate.HasValue;
        }
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("trackingType")]
        public TrackingType? TrackingType { get; set; }
        public bool ShouldSerializeTrackingType()
        {
            return TrackingType.HasValue;
        }
    }
}
