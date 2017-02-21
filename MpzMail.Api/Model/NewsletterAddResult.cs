using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterAddResult : BaseResult
    {
        [XmlElement("newsletterID")]
        public int NewsletterId { get; set; }
    }
}
