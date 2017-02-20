using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class CampaignSubscriber
    {
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("lastAction")]
        public DateTime LastActionDate { get; set; }
        [XmlElement("bindID")]
        public int BindId { get; set; }
        [XmlElement("customField1")]
        public string CustomField { get; set; }
        [XmlElement("bounceType")]
        public BounceType BounceType { get; set; }
    }
}
