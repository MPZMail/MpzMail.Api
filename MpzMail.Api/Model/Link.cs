using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("linkClicked")]
    public class Link
    {
        [XmlIgnore]
        public DateTime ClickDate { get; set; }
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
        [XmlElement("dateClicked")]
        public string ClickDateString {
            get { return this.ClickDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.ClickDate = DateTime.Parse(value); }
        }
        [XmlElement("urlClicked")]
        public string ClickUrl { get; set; }
        [XmlElement("trackingType")]
        public TrackingType TrackingType { get; set; }
        [XmlElement("bindID")]
        public int BindId { get; set; }
        [XmlElement("customField1")]
        public string CustomField { get; set; }
    }
}
