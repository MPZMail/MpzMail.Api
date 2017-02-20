using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignAddRequest : BaseRequest
    {
        private string _startDate;
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlAttribute("segmentID")]
        public int SegmentId { get; set; }
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
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
        [XmlElement("subject")]
        public string Subject { get; set; }
        [XmlElement("startDate")]
        public string StartDate { get; set; }
        [XmlElement("includeFooter")]
        public IncludeFooter IncludeFooter { get; set; }
    }
}
