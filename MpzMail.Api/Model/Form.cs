using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Form
    {
        [XmlElement("formID")]
        public int Id { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDate { get; set; }
        [XmlElement("formTitle")]
        public string Title { get; set; }
        [XmlElement("formHtml")]
        public string Html { get; set; }
        [XmlElement("impresssions")]
        public int Viewed { get; set; }
        [XmlElement("signups")]
        public int Registered { get; set; }
        [XmlElement("formType")]
        public FormType Type { get; set; }
    }
}
