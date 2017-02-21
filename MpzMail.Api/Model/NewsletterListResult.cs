using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterListResult : BaseResult
    {
        [XmlElement("newsletterCnt")]
        public int Count { get; set; }
        [XmlArray("newsletters")]
        [XmlArrayItem("newsletter")]
        public List<Newsletter> Newsletters { get; set; }
    }
}
