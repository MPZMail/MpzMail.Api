using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignAddRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("segmentID")]
        public int? SegmentId { get; set; }
        public bool ShouldSerializeSegmentId()
        {
            return SegmentId.HasValue;
        }
        [XmlElement("subscriberID")]
        public int? SubscriberId { get; set; }
        public bool ShouldSerializeSubscriberId()
        {
            return SubscriberId.HasValue;
        }
        [XmlElement("newsletterID")]
        public int NewsletterId { get; set; }
        [XmlElement("campaignName")]
        public string CampaignName { get; set; }
        [XmlElement("senderName")]
        public string SenderName { get; set; }
        [XmlElement("senderEmail")]
        public string SenderEmail { get; set; }
        [XmlElement("fromEmail")]
        public string FromEmail { get; set; }
        public bool ShouldSerializeFromEmail()
        {
            return !string.IsNullOrEmpty(FromEmail);
        }
        [XmlElement("subject")]
        public string Subject { get; set; }
        [XmlElement("startDate")]
        public DateTime StartDate { get; set; }
        [XmlElement("includeFooter")]
        public IncludeFooter? IncludeFooter { get; set; }
        public bool ShouldSerializeIncludeFooter()
        {
            return IncludeFooter.HasValue;
        }
    }
}
