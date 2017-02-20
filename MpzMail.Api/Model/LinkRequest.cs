using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class LinkRequest : BaseRequest
    {
        [XmlIgnore]
        public DateTime FromDate { get; set; }
        [XmlIgnore]
        public DateTime ToDate { get; set; }
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("trackingType")]
        public TrackingType TrackingType { get; set; }
        [XmlElement("fromDate")]
        public string FromDateString {
            get { return this.FromDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.FromDate = DateTime.Parse(value); }
        }
        [XmlElement("toDate")]
        public string ToDateString {
            get { return this.ToDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.ToDate = DateTime.Parse(value); }
        }
    }
}
