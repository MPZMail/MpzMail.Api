using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Newsletter
    {
        [XmlElement("newsletterID")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDate { get; set; }
        [XmlElement("lastUpdated")]
        public string UpdateDate { get; set; }
        [XmlElement("newsletterHTML")]
        public string Html { get; set; }
    }
}
