using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Newsletter
    {
        [XmlIgnore]
        public DateTime CreateDate { get; set; }
        [XmlIgnore]
        public DateTime UpdateDate { get; set; }
        [XmlElement("newsletterID")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDateString {
            get { return this.CreateDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.CreateDate = DateTime.Parse(value); }
        }
        [XmlElement("lastUpdated")]
        public string UpdateDateString {
            get { return this.UpdateDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.UpdateDate = DateTime.Parse(value); }
        }
        [XmlElement("newsletterHTML")]
        public string Html { get; set; }
    }
}
