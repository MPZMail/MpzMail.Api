using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SegmentListResult : BaseResult
    {
        [XmlElement("segmentCnt")]
        public int SegmentCount { get; set; }
        [XmlArray("segments")]
        [XmlArrayItem("segment")]
        public List<Segment> Segments { get; set; }
    }
}
