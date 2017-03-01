using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterAddRequest : BaseRequest
    {
        [XmlElement("newsletterName")]
        public string NewsletterName { get; set; }
        [XmlElement("newsletterHTML")]
        public string Html { get; set; }
    }
}
