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
    public class SegmentUpdateRequest : BaseRequest
    {
        [XmlElement("segmentID")]
        public int Id { get; set; }
        [XmlElement("matchType")]
        public MatchType MatchType { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlArray("segmentRules")]
        [XmlArrayItem("rule")]
        public List<SegmentRule> Rules { get; set; }
        [XmlElement("segmentName")]
        public string SegmentName { get; set; }
        public bool ShouldSerializeSegmentName()
        {
            return !string.IsNullOrEmpty(SegmentName);
        }
    }
}
