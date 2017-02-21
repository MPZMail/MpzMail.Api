using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Newsletter
    {
        [XmlElement("dateCreated")]
        public DateTime CreateDate { get; set; }
        [XmlElement("lastUpdated")]
        public DateTime UpdateDate { get; set; }
        [XmlElement("newsletterID")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("newsletterHTML")]
        public string Html { get; set; }
    }
}
