using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Campaign
    {
        [XmlElement("campaignID")]
        public int Id { get; set; }
        [XmlElement("campaignName")]
        public string Name { get; set; }
        [XmlIgnore]
        public DateTime CreateDate { get; set; }
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDateString {
            get { return this.CreateDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.CreateDate = DateTime.Parse(value);  }
        }

        [XmlElement("sentFrom")]
        public string SentFrom { get; set; }
        [XmlElement("subject")]
        public string Subject { get; set; }

        [XmlElement("startDate")]
        public string startDate {
            get { return this.StartDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.StartDate = DateTime.Parse(value); }
        }

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
