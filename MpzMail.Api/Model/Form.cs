using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Form
    {
        [XmlElement("dateCreated")]
        public DateTime CreateDate { get; set; }
        [XmlElement("formID")]
        public int Id { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("formTitle")]
        public string Title { get; set; }
        [XmlElement("formHtml")]
        public string Html { get; set; }
        [XmlElement("impressions")]
        public int ViewCount { get; set; }
        [XmlElement("signups")]
        public int RegisterCount { get; set; }
        [XmlElement("formType")]
        public FormType Type { get; set; }
    }
}
