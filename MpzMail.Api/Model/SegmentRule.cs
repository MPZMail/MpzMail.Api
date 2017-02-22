using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SegmentRule
    {
        [XmlElement("field")]
        public SegmentField Field { get; set; }
        [XmlElement("modifier")]
        public SegmentModifier Modifier { get; set; }
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
