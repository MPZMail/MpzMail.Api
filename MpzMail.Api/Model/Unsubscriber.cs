using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Unsubscriber
    {
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("unsubscribedDate")]
        public string UnsubscribedDate { get; set; }
    }
}
