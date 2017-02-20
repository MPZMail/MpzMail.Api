using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Campaign
    {
        [XmlElement("campaignID")]
        public int Id { get; set; }
        [XmlElement("campaignName")]
        public string Name { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDate { get; set; }
        [XmlElement("sentFrom")]
        public string SentFrom { get; set; }
        [XmlElement("subject")]
        public string Subject { get; set; }
        [XmlElement("startDate")]
        public string StartDate { get; set; }
        [XmlElement("status")]
        public CampaignStatus Status { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("emailFrom")]
        public string EmailFrom { get; set; }
        [XmlElement("totalRecipients")]
        public int TotalRecipients { get; set; }
        [XmlElement("opened")]
        public int Opened { get; set; }
        [XmlElement("clicks")]
        public int Clicks { get; set; }
        [XmlElement("unsubscribers")]
        public int Unsubscribers { get; set; }
        [XmlElement("bounced")]
        public int Bounced { get; set; }
        public int NewsletterId { get; set; }
        public string Newsletter { get; set; }
    }
}
