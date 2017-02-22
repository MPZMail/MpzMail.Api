using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SegmentAddRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("segmentName")]
        public string Name { get; set; }
        [XmlElement("matchType")]
        public MatchType MatchType { get; set; }
        [XmlArray("segmentRules")]
        [XmlArrayItem("rule")]
        public List<SegmentRule> Rules { get; set; }
    }
}
