using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class LinkResult : BaseResult
    {
        [XmlElement("linksCnt")]
        public int Count { get; set; }

        [XmlArray("linksClicked")]
        [XmlArrayItem("linkClicked")]
        public List<Link> Links { get; set; }
    }
}
